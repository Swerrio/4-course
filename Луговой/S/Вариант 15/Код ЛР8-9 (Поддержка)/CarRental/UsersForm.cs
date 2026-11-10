using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental
{
    // Управление учётными записями. Раздел доступен только
    // администратору: кнопка скрыта в главном окне, а каждая операция
    // дополнительно проверяет роль.
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable table = UserRepository.LoadAll();
                dgvUsers.DataSource = table;
                NameColumns();
                Status("Учётных записей: " + table.Rows.Count, true);
            }
            catch (AccessDeniedException ex)
            {
                Status(ex.Message, false);
                MessageBox.Show(ex.Message);
                this.Close();
            }
            catch (Exception ex)
            {
                Status("Ошибка чтения из базы: " + ex.Message, false);
            }
        }

        private void NameColumns()
        {
            if (dgvUsers.Columns.Count < 7)
            {
                return;
            }
            dgvUsers.Columns["id"].HeaderText = "№";
            dgvUsers.Columns["id"].Width = 46;
            dgvUsers.Columns["login"].HeaderText = "Логин";
            dgvUsers.Columns["role"].HeaderText = "Роль";
            dgvUsers.Columns["first_name"].HeaderText = "Имя";
            dgvUsers.Columns["last_name"].HeaderText = "Фамилия";
            dgvUsers.Columns["phone"].HeaderText = "Телефон";
            dgvUsers.Columns["email"].HeaderText = "Почта";
        }

        private int SelectedId()
        {
            if (dgvUsers.CurrentRow == null)
            {
                return -1;
            }
            object value = dgvUsers.CurrentRow.Cells["id"].Value;
            return value == null ? -1 : Convert.ToInt32(value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPwd.Text;

            if (login.Length == 0 || password.Length < 6)
            {
                Status("Укажите логин и пароль не короче 6 символов.",
                    false);
                return;
            }

            try
            {
                UserRepository.AddUser(login, password, cmbRole.Text);
            }
            catch (AccessDeniedException ex)
            {
                Status(ex.Message, false);
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Status("Не удалось создать запись: " + ex.Message, false);
                return;
            }

            txtLogin.Clear();
            txtPwd.Clear();
            LoadData();
            Status("Учётная запись «" + login + "» создана.", true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = SelectedId();
            if (id < 0)
            {
                Status("Выберите учётную запись в таблице.", false);
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Удалить учётную запись № " + id + "?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                UserRepository.DeleteUser(id);
            }
            catch (AccessDeniedException ex)
            {
                Status(ex.Message, false);
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Status("Не удалось удалить запись: " + ex.Message, false);
                return;
            }

            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Status(string text, bool ok)
        {
            lblStatus.Text = text;
            lblStatus.ForeColor = ok
                ? Color.FromArgb(26, 110, 60) : Color.FromArgb(168, 42, 42);
        }
    }
}
