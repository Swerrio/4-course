using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
            UpdateList();
        }

        private void UpdateList()
        {
            lstCars.Items.Clear();
            foreach (Car car in CarStorage.Cars)
            {
                string text = car.Brand + " " + car.Model + " — ";
                lstCars.Items.Add(text + car.Price + " руб. — " + car.Type);
            }
            lblFilterInfo.Text = "Показаны все автомобили: " +
                CarStorage.Cars.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Введите марку автомобиля");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену");
                return;
            }

            Car car = new Car();
            car.Brand = txtBrand.Text;
            car.Model = txtModel.Text;
            car.Price = price;
            car.Type = cmbType.Text;
            CarStorage.Cars.Add(car);

            UpdateList();

            txtBrand.Clear();
            txtModel.Clear();
            txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите автомобиль в списке");
                return;
            }

            CarStorage.Cars.RemoveAt(lstCars.SelectedIndex);
            UpdateList();
        }

        // кнопка «Показать» — фильтрация автомобилей по типу
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string type = cmbFilter.Text;
            lstCars.Items.Clear();
            int count = 0;

            foreach (Car car in CarStorage.Cars)
            {
                if (type == "Все типы" || car.Type == type)
                {
                    string text = car.Brand + " " + car.Model + " — ";
                    lstCars.Items.Add(text + car.Price + " руб. — " + car.Type);
                    count++;
                }
            }

            lblFilterInfo.Text = "Показано автомобилей: " + count;
        }

        // кнопка «Добавить фото»
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

        // кнопка «Очистить фото»
        private void btnClearImage_Click(object sender, EventArgs e)
        {
            picCar.Image = null;
            lblImageName.Text = "изображение не выбрано";
        }

        // кнопка «НАЗАД» — возврат в главное меню
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
