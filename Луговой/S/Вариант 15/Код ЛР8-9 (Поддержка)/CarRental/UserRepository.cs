using System;
using System.Data;
using System.Data.Common;

namespace CarRental
{
    // Работа с таблицей users: вход в систему, профиль, управление
    // учётными записями.
    public static class UserRepository
    {
        // Проверка логина и пароля. Запрос параметризован, поэтому
        // кавычки и фрагменты SQL в логине не меняют смысл запроса.
        public static AppUser Authenticate(string login, string password)
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT id, login, password_hash, role, first_name, " +
                    "last_name, phone, email, photo_path, created_at " +
                    "FROM users WHERE login = @login"))
                {
                    Db.Param(cmd, "@login", login);
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }
                        string hash = Convert.ToString(
                            reader["password_hash"]);
                        if (!PasswordHasher.Verify(password, hash))
                        {
                            return null;
                        }
                        return Read(reader);
                    }
                }
            }
        }

        public static AppUser GetById(int id)
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT id, login, password_hash, role, first_name, " +
                    "last_name, phone, email, photo_path, created_at " +
                    "FROM users WHERE id = @id"))
                {
                    Db.Param(cmd, "@id", id);
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? Read(reader) : null;
                    }
                }
            }
        }

        // Список учётных записей — только для администратора
        public static DataTable LoadAll()
        {
            Session.RequireAdmin("просмотр учётных записей");
            using (DbConnection conn = Db.Open())
            {
                return Db.Select(conn,
                    "SELECT id, login, role, first_name, last_name, " +
                    "phone, email FROM users ORDER BY id");
            }
        }

        public static void AddUser(string login, string password,
            string role)
        {
            Session.RequireAdmin("создание учётной записи");
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "INSERT INTO users (login, password_hash, role) " +
                    "VALUES (@login, @hash, @role)"))
                {
                    Db.Param(cmd, "@login", login);
                    Db.Param(cmd, "@hash", PasswordHasher.Hash(password));
                    Db.Param(cmd, "@role", role);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(int id)
        {
            Session.RequireAdmin("удаление учётной записи");
            if (Session.Current != null && Session.Current.Id == id)
            {
                throw new AccessDeniedException(
                    "Нельзя удалить учётную запись, под которой " +
                    "выполнен вход.");
            }
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "DELETE FROM users WHERE id = @id"))
                {
                    Db.Param(cmd, "@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ------------------------------------------------- профиль
        public static void UpdateProfile(AppUser user)
        {
            Session.RequireSelf(user.Id, "изменение профиля");
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "UPDATE users SET first_name = @first, " +
                    "last_name = @last, phone = @phone, email = @email, " +
                    "photo_path = @photo WHERE id = @id"))
                {
                    Db.Param(cmd, "@first", user.FirstName);
                    Db.Param(cmd, "@last", user.LastName);
                    Db.Param(cmd, "@phone", user.Phone);
                    Db.Param(cmd, "@email", user.Email);
                    Db.Param(cmd, "@photo", user.PhotoPath);
                    Db.Param(cmd, "@id", user.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Смена пароля: старый пароль проверяется обязательно
        public static bool ChangePassword(int id, string oldPassword,
            string newPassword)
        {
            Session.RequireSelf(id, "смена пароля");
            AppUser user = GetById(id);
            if (user == null)
            {
                return false;
            }

            string stored = StoredHash(id);
            if (!PasswordHasher.Verify(oldPassword, stored))
            {
                return false;
            }

            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "UPDATE users SET password_hash = @hash WHERE id = @id"))
                {
                    Db.Param(cmd, "@hash",
                        PasswordHasher.Hash(newPassword));
                    Db.Param(cmd, "@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        private static string StoredHash(int id)
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT password_hash FROM users WHERE id = @id"))
                {
                    Db.Param(cmd, "@id", id);
                    object value = cmd.ExecuteScalar();
                    return value == null ? "" : Convert.ToString(value);
                }
            }
        }

        public static int Count()
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT COUNT(*) FROM users"))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Две учебные учётные записи создаются кодом, который считает
        // парольный хеш; в SQL пароли не попадают
        public static void SeedDefaultUsers()
        {
            if (Count() > 0)
            {
                return;
            }
            Insert("admin", "Admin#2026", "Admin", "Никита", "Нестеренко",
                "+7 900 000-00-00", "admin@carrental.local");
            Insert("user", "User#2026", "User", "Иван", "Петров",
                "+7 900 111-11-11", "user@carrental.local");
        }

        private static void Insert(string login, string password,
            string role, string first, string last, string phone,
            string email)
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "INSERT INTO users (login, password_hash, role, " +
                    "first_name, last_name, phone, email) VALUES " +
                    "(@login, @hash, @role, @first, @last, @phone, @email)"))
                {
                    Db.Param(cmd, "@login", login);
                    Db.Param(cmd, "@hash", PasswordHasher.Hash(password));
                    Db.Param(cmd, "@role", role);
                    Db.Param(cmd, "@first", first);
                    Db.Param(cmd, "@last", last);
                    Db.Param(cmd, "@phone", phone);
                    Db.Param(cmd, "@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static AppUser Read(DbDataReader reader)
        {
            AppUser user = new AppUser();
            user.Id = Convert.ToInt32(reader["id"]);
            user.Login = Convert.ToString(reader["login"]);
            user.Role = Convert.ToString(reader["role"]);
            user.FirstName = Text(reader, "first_name");
            user.LastName = Text(reader, "last_name");
            user.Phone = Text(reader, "phone");
            user.Email = Text(reader, "email");
            user.PhotoPath = Text(reader, "photo_path");
            object created = reader["created_at"];
            user.CreatedAt = created == DBNull.Value
                ? DateTime.Now : Convert.ToDateTime(created);
            return user;
        }

        private static string Text(DbDataReader reader, string column)
        {
            object value = reader[column];
            return value == DBNull.Value ? "" : Convert.ToString(value);
        }
    }
}
