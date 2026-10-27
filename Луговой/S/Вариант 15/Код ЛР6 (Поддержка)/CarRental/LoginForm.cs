using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // кнопка «ВОЙТИ» — проверка логина и пароля
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            if (login == "admin" && password == "1234")
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
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
