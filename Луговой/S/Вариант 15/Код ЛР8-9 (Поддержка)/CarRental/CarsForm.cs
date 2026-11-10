using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    // Каталог автомобилей. С ЛР №8 данные берутся из базы данных:
    // добавление, изменение и удаление выполняются SQL-запросами,
    // после каждой операции список перечитывается из БД.
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
            ApplyRole();
            LoadData();
        }

        // Кнопки изменения каталога доступны только администратору.
        // Сами операции дополнительно проверяют роль в репозитории.
        private void ApplyRole()
        {
            bool admin = Session.IsAdmin;
            btnAdd.Enabled = admin;
            btnEdit.Enabled = admin;
            btnDelete.Enabled = admin;
            if (!admin)
            {
                grpData.Text = "Данные автомобиля (только просмотр)";
            }
        }

        // Загрузка записей из базы в таблицу на форме
        private void LoadData()
        {
            try
            {
                DataTable table = CarRepository.Load(cmbFilter.Text);
                dgvCars.DataSource = table;
                NameColumns();
                lblFilterInfo.Text = cmbFilter.Text == "Все типы"
                    ? "Показаны все автомобили: " + table.Rows.Count
                    : "Показано автомобилей: " + table.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные из базы: " +
                    ex.Message);
            }
        }

        private void NameColumns()
        {
            if (dgvCars.Columns.Count < 5)
            {
                return;
            }
            dgvCars.Columns["id"].HeaderText = "№";
            dgvCars.Columns["id"].Width = 46;
            dgvCars.Columns["brand"].HeaderText = "Марка";
            dgvCars.Columns["brand"].Width = 96;
            dgvCars.Columns["model"].HeaderText = "Модель";
            dgvCars.Columns["model"].Width = 120;
            dgvCars.Columns["car_type"].HeaderText = "Тип";
            dgvCars.Columns["car_type"].Width = 96;
            dgvCars.Columns["price"].HeaderText = "Цена";
        }

        // Идентификатор выбранной записи базы данных
        private int SelectedId()
        {
            if (dgvCars.CurrentRow == null ||
                dgvCars.CurrentRow.Index < 0)
            {
                return -1;
            }
            object value = dgvCars.CurrentRow.Cells["id"].Value;
            return value == null ? -1 : Convert.ToInt32(value);
        }

        // При выборе строки её данные показываются в полях ввода
        private void dgvCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null)
            {
                return;
            }
            DataGridViewRow row = dgvCars.CurrentRow;
            if (row.Cells["brand"].Value == null)
            {
                return;
            }
            txtBrand.Text = Convert.ToString(row.Cells["brand"].Value);
            txtModel.Text = Convert.ToString(row.Cells["model"].Value);
            txtPrice.Text = Convert.ToString(row.Cells["price"].Value);
            cmbType.Text = Convert.ToString(row.Cells["car_type"].Value);
        }

        // Проверка введённых данных сохранена из предыдущих работ
        private bool ReadForm(Car car)
        {
            if (txtBrand.Text.Trim() == "")
            {
                MessageBox.Show("Введите марку автомобиля");
                return false;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену");
                return false;
            }

            car.Brand = txtBrand.Text.Trim();
            car.Model = txtModel.Text.Trim();
            car.Price = price;
            car.Type = cmbType.Text;
            return true;
        }

        // INSERT в базу данных
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            if (!ReadForm(car))
            {
                return;
            }

            try
            {
                CarRepository.Add(car);
            }
            catch (AccessDeniedException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка записи в базу данных: " +
                    ex.Message);
                return;
            }

            LoadData();
            txtBrand.Clear();
            txtModel.Clear();
            txtPrice.Clear();
        }

        // UPDATE по первичному ключу
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedId();
            if (id < 0)
            {
                MessageBox.Show("Выберите автомобиль в таблице");
                return;
            }

            Car car = new Car();
            car.Id = id;
            if (!ReadForm(car))
            {
                return;
            }

            try
            {
                CarRepository.Update(car);
            }
            catch (AccessDeniedException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка изменения записи: " + ex.Message);
                return;
            }

            LoadData();
        }

        // DELETE по первичному ключу, а не по номеру строки
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = SelectedId();
            if (id < 0)
            {
                MessageBox.Show("Выберите автомобиль в таблице");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Удалить запись № " + id + " из базы данных?",
                "Подтверждение", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                CarRepository.Delete(id);
            }
            catch (AccessDeniedException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления записи: " + ex.Message);
                return;
            }

            LoadData();
        }

        // Фильтрация по типу выполняется запросом к базе
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofdImage.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string ext = Path.GetExtension(ofdImage.FileName).ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" &&
                ext != ".bmp")
            {
                MessageBox.Show("Выберите файл изображения: jpg, png или bmp");
                return;
            }

            picCar.Image = Image.FromFile(ofdImage.FileName);
            lblImageName.Text = Path.GetFileName(ofdImage.FileName);
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            picCar.Image = null;
            lblImageName.Text = "изображение не выбрано";
        }

        // Карточка открывается для записи, выбранной в таблице;
        // данные перечитываются из базы на момент открытия
        private void btnCard_Click(object sender, EventArgs e)
        {
            int id = SelectedId();
            if (id < 0)
            {
                MessageBox.Show("Выберите автомобиль в таблице");
                return;
            }

            Car car;
            try
            {
                car = CarRepository.GetById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения записи: " + ex.Message);
                return;
            }

            if (car == null)
            {
                MessageBox.Show("Запись не найдена в базе данных");
                LoadData();
                return;
            }

            CarCardForm form = new CarCardForm(car, picCar.Image);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
