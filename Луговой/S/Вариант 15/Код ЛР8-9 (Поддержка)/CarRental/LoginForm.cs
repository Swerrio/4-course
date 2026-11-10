using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblDb.Text = "Хранилище данных: " +
                (Db.Provider == DbProvider.Sqlite
                    ? "SQLite" : "PostgreSQL");
        }

        // кнопка «ВОЙТИ» — проверка учётных данных по базе
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Введите логин и пароль.";
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            AppUser user;
            try
            {
                user = UserRepository.Authenticate(login, password);
            }
            catch (Exception ex)
            {
                lblError.Text = "Нет связи с базой данных.";
                MessageBox.Show("Нет связи с базой данных: " + ex.Message);
                return;
            }

            if (user == null)
            {
                lblError.Text = "Неверный логин или пароль.";
                MessageBox.Show("Неверный логин или пароль.");
                return;
            }

            Session.Current = user;
            OpenCabinet();
        }

        // После входа открывается кабинет, соответствующий роли.
        // При выходе из учётной записи программа возвращается сюда.
        private void OpenCabinet()
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            Session.Clear();
            txtPassword.Clear();
            lblError.Text = "";

            if (mainForm.LoggedOut)
            {
                this.Show();
                txtLogin.Focus();
            }
            else
            {
                this.Close();
            }
        }

        // кнопка «ВЫХОД» — закрытие программы
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // показать или скрыть символы пароля
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }
    }
}
