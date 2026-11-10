using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using Npgsql;

namespace CarRental
{
    // Какая база используется приложением
    public enum DbProvider
    {
        Postgres,
        Sqlite
    }

    // Единая точка работы с базой данных: строка подключения, создание
    // соединений и команд, создание схемы.
    //
    // Приложение умеет работать с двумя хранилищами:
    //   PostgreSQL — основной вариант, подключение через Npgsql;
    //   SQLite     — запасной вариант, файл базы лежит рядом с программой
    //                и не требует запущенного сервера.
    // Оба варианта используют один и тот же SQL-код приложения, отличаются
    // только строкой подключения и текстом создания таблиц.
    public static class Db
    {
        public const string PostgresDefault =
            "Host=localhost;Port=5432;Database=carrental;" +
            "Username=postgres;Password=";

        public static DbProvider Provider = DbProvider.Postgres;
        public static string ConnectionString = PostgresDefault;

        public static string AppFolder
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }

        public static string SqliteDefault
        {
            get
            {
                return "Data Source=" +
                    Path.Combine(AppFolder, "carrental.db");
            }
        }

        // Короткое описание хранилища для вывода на экран.
        // Строка подключения целиком и пароль на экран не выводятся.
        public static string Description
        {
            get
            {
                if (Provider == DbProvider.Sqlite)
                {
                    return "SQLite, файл " +
                        Path.GetFileName(SqliteFile);
                }

                string host = Value(ConnectionString, "Host");
                string port = Value(ConnectionString, "Port");
                string database = Value(ConnectionString, "Database");
                string server = host;
                if (port.Length > 0)
                {
                    server = server + ":" + port;
                }
                return "PostgreSQL, база " + database +
                    " на сервере " + server;
            }
        }

        public static string SqliteFile
        {
            get
            {
                string s = ConnectionString;
                int i = s.IndexOf('=');
                return i < 0 ? s : s.Substring(i + 1).Trim();
            }
        }

        // ------------------------------------------------- соединения
        public static DbConnection Open()
        {
            DbConnection conn;
            if (Provider == DbProvider.Sqlite)
            {
                conn = new SQLiteConnection(ConnectionString);
            }
            else
            {
                conn = new NpgsqlConnection(ConnectionString);
            }
            conn.Open();
            return conn;
        }

        public static DbCommand Command(DbConnection conn, string sql)
        {
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            return cmd;
        }

        // Параметр запроса. Пользовательский ввод всегда передаётся
        // параметром, а не склеивается со строкой SQL.
        public static void Param(DbCommand cmd, string name, object value)
        {
            DbParameter p = cmd.CreateParameter();
            p.ParameterName = name;
            p.Value = value == null ? DBNull.Value : value;
            cmd.Parameters.Add(p);
        }

        public static DataTable Select(DbConnection conn, string sql)
        {
            DataTable table = new DataTable();
            using (DbCommand cmd = Command(conn, sql))
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            return table;
        }

        // Проверка подключения: используется в окне настроек
        public static bool TestConnection(out string error)
        {
            error = "";
            try
            {
                using (DbConnection conn = Open())
                {
                    using (DbCommand cmd = Command(conn, "SELECT 1"))
                    {
                        cmd.ExecuteScalar();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // ------------------------------------------------- схема
        // Создание самой базы данных PostgreSQL, если её ещё нет.
        // Выполняется из программы, поэтому pgAdmin или другой внешний
        // инструмент для подготовки базы не требуется.
        public static void EnsureDatabase()
        {
            if (Provider != DbProvider.Postgres)
            {
                return;
            }

            string error;
            if (TestConnection(out error))
            {
                return;
            }

            string target = Value(ConnectionString, "Database");
            if (target.Length == 0)
            {
                return;
            }

            // служебная база postgres есть на любом сервере
            string master = Replace(ConnectionString, "Database",
                "postgres");
            using (NpgsqlConnection conn = new NpgsqlConnection(master))
            {
                conn.Open();
                using (NpgsqlCommand check = new NpgsqlCommand(
                    "SELECT 1 FROM pg_database WHERE datname = @name",
                    conn))
                {
                    check.Parameters.AddWithValue("@name", target);
                    if (check.ExecuteScalar() != null)
                    {
                        return;
                    }
                }
                using (NpgsqlCommand create = new NpgsqlCommand(
                    "CREATE DATABASE \"" + target.Replace("\"", "") + "\"",
                    conn))
                {
                    create.ExecuteNonQuery();
                }
            }
        }

        private static string Value(string connectionString, string key)
        {
            foreach (string part in connectionString.Split(';'))
            {
                string[] kv = part.Split(new char[] { '=' }, 2);
                if (kv.Length == 2 && kv[0].Trim().Equals(key,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return kv[1].Trim();
                }
            }
            return "";
        }

        private static string Replace(string connectionString, string key,
            string value)
        {
            string[] parts = connectionString.Split(';');
            for (int i = 0; i < parts.Length; i++)
            {
                string[] kv = parts[i].Split(new char[] { '=' }, 2);
                if (kv.Length == 2 && kv[0].Trim().Equals(key,
                    StringComparison.OrdinalIgnoreCase))
                {
                    parts[i] = key + "=" + value;
                }
            }
            return string.Join(";", parts);
        }

        public static void EnsureSchema()
        {
            EnsureDatabase();
            using (DbConnection conn = Open())
            {
                foreach (string sql in SchemaSql())
                {
                    using (DbCommand cmd = Command(conn, sql))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            CarRepository.SeedDemoData();
            UserRepository.SeedDefaultUsers();
        }

        private static string[] SchemaSql()
        {
            if (Provider == DbProvider.Sqlite)
            {
                return new string[]
                {
                    "CREATE TABLE IF NOT EXISTS cars (" +
                    " id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    " brand TEXT NOT NULL," +
                    " model TEXT," +
                    " car_type TEXT," +
                    " price NUMERIC NOT NULL DEFAULT 0)",

                    "CREATE TABLE IF NOT EXISTS users (" +
                    " id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    " login TEXT NOT NULL UNIQUE," +
                    " password_hash TEXT NOT NULL," +
                    " role TEXT NOT NULL CHECK (role IN ('Admin','User'))," +
                    " first_name TEXT, last_name TEXT," +
                    " phone TEXT, email TEXT, photo_path TEXT," +
                    " created_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP)"
                };
            }

            return new string[]
            {
                "CREATE TABLE IF NOT EXISTS cars (" +
                " id SERIAL PRIMARY KEY," +
                " brand VARCHAR(100) NOT NULL," +
                " model VARCHAR(100)," +
                " car_type VARCHAR(50)," +
                " price NUMERIC(10,2) NOT NULL DEFAULT 0)",

                "CREATE TABLE IF NOT EXISTS users (" +
                " id SERIAL PRIMARY KEY," +
                " login VARCHAR(50) NOT NULL UNIQUE," +
                " password_hash TEXT NOT NULL," +
                " role VARCHAR(20) NOT NULL" +
                " CHECK (role IN ('Admin','User'))," +
                " first_name VARCHAR(80), last_name VARCHAR(80)," +
                " phone VARCHAR(30), email VARCHAR(120), photo_path TEXT," +
                " created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP)"
            };
        }

        // ------------------------------------------------- настройки
        private static string SettingsFile
        {
            get { return Path.Combine(AppFolder, "connection.cfg"); }
        }

        public static void SaveSettings()
        {
            try
            {
                File.WriteAllText(SettingsFile,
                    Provider + Environment.NewLine + ConnectionString);
            }
            catch
            {
                // настройки не критичны: при ошибке используются значения
                // по умолчанию
            }
        }

        public static void LoadSettings()
        {
            try
            {
                if (!File.Exists(SettingsFile))
                {
                    return;
                }
                string[] lines = File.ReadAllLines(SettingsFile);
                if (lines.Length >= 2)
                {
                    Provider = lines[0].Trim() == "Sqlite"
                        ? DbProvider.Sqlite : DbProvider.Postgres;
                    ConnectionString = lines[1].Trim();
                }
            }
            catch
            {
            }
        }

        // Строка подключения без пароля — для вывода на экран и в отчёт
        public static string Hide(string connectionString)
        {
            string[] parts = connectionString.Split(';');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].TrimStart().StartsWith("Password",
                    StringComparison.OrdinalIgnoreCase))
                {
                    parts[i] = "Password=***";
                }
            }
            return string.Join(";", parts);
        }
    }
}
