using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental
{
    // Главное окно работает как личный кабинет: состав доступных
    // действий зависит от роли вошедшего пользователя.
    public partial class MainForm : Form
    {
        // true — пользователь вышел из учётной записи и должен
        // вернуться к форме входа
        public bool LoggedOut;

        public MainForm()
        {
            InitializeComponent();
            ApplyRole();
            ShowCatalogCount();
        }

        // Разграничение прав: администратору доступны управление
        // автомобилями и учётными записями, обычному пользователю —
        // просмотр, поиск, карточка и собственный профиль
        private void ApplyRole()
        {
            string login = Session.Current == null
                ? "гость" : Session.Current.Login;
            lblTitle.Text = Session.IsAdmin
                ? "КАБИНЕТ АДМИНИСТРАТОРА"
                : "КАБИНЕТ ПОЛЬЗОВАТЕЛЯ";
            lblSub.Text = "Вход выполнен: " + login +
                " (" + Session.RoleName + ")";
            this.Text = "АвтоПрокат — " +
                (Session.IsAdmin ? "кабинет администратора"
                                 : "кабинет пользователя");

            btnUsers.Visible = Session.IsAdmin;
            lblNavHint.Text = Session.IsAdmin
                ? "«Автомобили»: каталог и редактирование записей базы. " +
                  "«Аренда»: расчёт стоимости. «Пользователи»: учётные записи."
                : "«Автомобили»: просмотр каталога и карточка автомобиля. " +
                  "«Аренда»: расчёт стоимости. Изменение каталога " +
                  "доступно только администратору.";
        }

        private void ShowCatalogCount()
        {
            try
            {
                lblStatus.Text = "Автомобилей в базе: " +
                    CarRepository.Count();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Нет связи с базой данных: " + ex.Message;
            }
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm form = new CarsForm();
            form.ShowDialog();
            ShowCatalogCount();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentForm form = new RentForm();
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm();
            form.ShowDialog();
            ApplyRole();
        }

        // Управление учётными записями: кнопка скрыта для обычного
        // пользователя, а сама операция дополнительно проверяет роль
        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                Session.RequireAdmin("управление учётными записями");
            }
            catch (AccessDeniedException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            UsersForm form = new UsersForm();
            form.ShowDialog();
        }

        // поиск автомобиля по марке — запрос к базе данных
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Введите марку автомобиля для поиска");
                return;
            }

            lstInfo.Items.Clear();
            try
            {
                DataTable table = CarRepository.Search(txtSearch.Text);
                foreach (DataRow row in table.Rows)
                {
                    lstInfo.Items.Add(
                        "№ " + row["id"] + ", " + row["brand"] + " " +
                        row["model"] + ", " + row["price"] +
                        " руб./сутки, " + row["car_type"]);
                }
                if (table.Rows.Count == 0)
                {
                    lstInfo.Items.Add("По запросу «" + txtSearch.Text +
                        "» ничего не найдено");
                }
                lblStatus.Text = "Найдено автомобилей: " +
                    table.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка запроса к базе данных: " +
                    ex.Message);
            }
        }

        // кнопка «ВЫЙТИ» — выход из учётной записи
        private void btnExit_Click(object sender, EventArgs e)
        {
            LoggedOut = true;
            this.Close();
        }

        // кнопка «ЗАВЕРШИТЬ» — закрытие программы
        private void btnQuit_Click(object sender, EventArgs e)
        {
            LoggedOut = false;
            this.Close();
        }
    }
}
