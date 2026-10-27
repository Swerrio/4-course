using System;
using System.Windows.Forms;

namespace CarRental
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// Программа начинается с окна входа: главное окно открывается
        /// только после успешной авторизации.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
