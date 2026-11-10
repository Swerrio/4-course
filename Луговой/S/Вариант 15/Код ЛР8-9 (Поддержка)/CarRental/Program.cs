using System;
using System.Windows.Forms;

namespace CarRental
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// Сначала выбирается хранилище данных (PostgreSQL или SQLite),
        /// затем выполняется вход в систему, и только после этого
        /// открывается кабинет пользователя.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnectionForm connection = new ConnectionForm();
            if (connection.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new LoginForm());
        }
    }
}
