using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
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
            cars.Add(car);

            UpdateList();

            txtBrand.Clear();
            txtModel.Clear();
            txtPrice.Clear();
        }

        private void UpdateList()
        {
            lstCars.Items.Clear();
            foreach (Car car in cars)
            {
                string text = car.Brand + " " + car.Model + " — ";
                lstCars.Items.Add(text + car.Price + " руб. — " + car.Type);
            }
            lblFilterInfo.Text = "Показаны все автомобили: " + cars.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Car car in cars)
            {
                if (car.Brand == txtSearch.Text)
                {
                    MessageBox.Show("Найдено:\n\n" + car.Brand + " " + car.Model +
                        "\nЦена за сутки: " + car.Price + " руб." +
                        "\nТип: " + car.Type);
                    return;
                }
            }
            MessageBox.Show("Автомобиль не найден");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите автомобиль в списке");
                return;
            }

            cars.RemoveAt(lstCars.SelectedIndex);
            UpdateList();
            lblResult.Text = "";
        }

        // кнопка «Показать» — фильтрация автомобилей по типу
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string type = cmbFilter.Text;
            lstCars.Items.Clear();
            int count = 0;

            foreach (Car car in cars)
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите автомобиль в списке");
                return;
            }

            int days;
            if (!int.TryParse(txtDays.Text, out days))
            {
                MessageBox.Show("Введите количество дней числом");
                return;
            }
            if (days < 1 || days > 365)
            {
                MessageBox.Show("Количество дней должно быть от 1 до 365");
                return;
            }

            CalculateRent(days);
        }

        // расчёт стоимости аренды выбранного автомобиля
        private void CalculateRent(int days)
        {
            Car car = cars[lstCars.SelectedIndex];
            decimal total = car.Price * days;
            lblResult.Text = "Стоимость аренды: " + total + " руб.";
        }

        // кнопка «Добавить изображение»
        private void btnImage_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofdImage.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string ext = Path.GetExtension(ofdImage.FileName).ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" && ext != ".bmp")
            {
                MessageBox.Show("Выберите файл изображения: jpg, png или bmp");
                return;
            }

            picCar.Image = Image.FromFile(ofdImage.FileName);
            lblImageName.Text = Path.GetFileName(ofdImage.FileName);
        }

        // кнопка «Очистить изображение»
        private void btnClearImage_Click(object sender, EventArgs e)
        {
            picCar.Image = null;
            lblImageName.Text = "изображение не выбрано";
        }
    }
}
