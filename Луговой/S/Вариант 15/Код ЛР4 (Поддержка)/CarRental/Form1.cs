using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
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
                string text = car.Brand + " " + car.Model;
                lstCars.Items.Add(text + " — " + car.Price + " руб.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Car car in cars)
            {
                if (car.Brand == txtSearch.Text)
                {
                    MessageBox.Show("Найдено:\n\n" + car.Brand + " " + car.Model +
                        "\nЦена за сутки: " + car.Price + " руб.");
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
        }

        // кнопка «Рассчитать»
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

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
