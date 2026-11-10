using System;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    // Окно выбора хранилища данных. Открывается перед входом в систему.
    //
    // Если PostgreSQL на компьютере не запущен (например, не работает
    // служба или не установлен pgAdmin для её настройки), программа
    // предлагает переключиться на SQLite — файл базы создаётся рядом
    // с программой, сервер не нужен.
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            Db.LoadSettings();
            FillFields();
            UpdateEnabled();
        }

        private void FillFields()
        {
            string host = "localhost";
            string port = "5432";
            string database = "carrental";
            string user = "postgres";
            string password = "";

            if (Db.Provider == DbProvider.Postgres)
            {
                foreach (string part in Db.ConnectionString.Split(';'))
                {
                    string[] kv = part.Split(new char[] { '=' }, 2);
                    if (kv.Length != 2)
                    {
                        continue;
                    }
                    string key = kv[0].Trim().ToLower();
                    if (key == "host") { host = kv[1]; }
                    if (key == "port") { port = kv[1]; }
                    if (key == "database") { database = kv[1]; }
                    if (key == "username") { user = kv[1]; }
                    if (key == "password") { password = kv[1]; }
                }
            }

            txtHost.Text = host;
            txtPort.Text = port;
            txtDatabase.Text = database;
            txtUser.Text = user;
            txtPwd.Text = password;
            txtFile.Text = Db.Provider == DbProvider.Sqlite
                ? Db.SqliteFile
                : Path.Combine(Db.AppFolder, "carrental.db");

            rbSqlite.Checked = Db.Provider == DbProvider.Sqlite;
            rbPostgres.Checked = Db.Provider == DbProvider.Postgres;
        }

        private void UpdateEnabled()
        {
            grpPg.Enabled = rbPostgres.Checked;
            grpLite.Enabled = rbSqlite.Checked;
        }

        private void Provider_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabled();
        }

        // Собрать настройки подключения из полей формы
        private void Apply()
        {
            if (rbSqlite.Checked)
            {
                Db.Provider = DbProvider.Sqlite;
                Db.ConnectionString = "Data Source=" + txtFile.Text.Trim();
            }
            else
            {
                Db.Provider = DbProvider.Postgres;
                Db.ConnectionString =
                    "Host=" + txtHost.Text.Trim() +
                    ";Port=" + txtPort.Text.Trim() +
                    ";Database=" + txtDatabase.Text.Trim() +
                    ";Username=" + txtUser.Text.Trim() +
                    ";Password=" + txtPwd.Text;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            sfdDatabase.FileName = txtFile.Text;
            if (sfdDatabase.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = sfdDatabase.FileName;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Apply();
            string error;
            if (Db.TestConnection(out error))
            {
                Status("Подключение выполнено. " + Db.Description, true);
            }
            else
            {
                Status("Подключиться не удалось: " + error, false);
            }
        }

        // Создание таблиц и начальных данных прямо из программы:
        // pgAdmin или другой внешний инструмент для этого не нужен
        private void btnInit_Click(object sender, EventArgs e)
        {
            Apply();
            try
            {
                Db.EnsureSchema();
                Status("Таблицы готовы. Автомобилей: " +
                    CarRepository.Count() + ", учётных записей: " +
                    UserRepository.Count() + ".", true);
            }
            catch (Exception ex)
            {
                Status("Не удалось создать таблицы: " + ex.Message, false);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Apply();

            // если базы ещё нет, программа создаёт её сама
            if (Db.Provider == DbProvider.Postgres)
            {
                try
                {
                    Db.EnsureDatabase();
                }
                catch
                {
                    // сервер недоступен — ниже будет предложен SQLite
                }
            }

            string error;
            if (!Db.TestConnection(out error))
            {
                if (Db.Provider == DbProvider.Postgres)
                {
                    DialogResult answer = MessageBox.Show(
                        "Не удалось подключиться к PostgreSQL:" +
                        Environment.NewLine + error + Environment.NewLine +
                        Environment.NewLine +
                        "Переключиться на запасное хранилище SQLite?" +
                        Environment.NewLine +
                        "Файл базы будет создан рядом с программой.",
                        "Нет связи с PostgreSQL",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (answer != DialogResult.Yes)
                    {
                        Status("Подключиться не удалось: " + error, false);
                        return;
                    }
                    rbSqlite.Checked = true;
                    Apply();
                    if (!Db.TestConnection(out error))
                    {
                        Status("SQLite также недоступен: " + error, false);
                        return;
                    }
                }
                else
                {
                    Status("Подключиться не удалось: " + error, false);
                    return;
                }
            }

            try
            {
                Db.EnsureSchema();
            }
            catch (Exception ex)
            {
                Status("Не удалось подготовить таблицы: " + ex.Message,
                    false);
                return;
            }

            Db.SaveSettings();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Status(string text, bool ok)
        {
            lblStatus.Text = text;
            lblStatus.ForeColor = ok
                ? System.Drawing.Color.FromArgb(26, 110, 60)
                : System.Drawing.Color.FromArgb(168, 42, 42);
        }
    }
}
