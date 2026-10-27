using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
            FillCars();
            foreach (string rent in CarStorage.Rents)
            {
                lstRents.Items.Add(rent);
            }
        }

        private void FillCars()
        {
            cmbCars.Items.Clear();
            foreach (Car car in CarStorage.Cars)
            {
                cmbCars.Items.Add(car.Brand + " " + car.Model);
            }
            if (cmbCars.Items.Count > 0)
            {
                cmbCars.SelectedIndex = 0;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите автомобиль");
                return;
            }

            CalculateRent((int)numDays.Value);
        }

        // расчёт стоимости аренды выбранного автомобиля
        private void CalculateRent(int days)
        {
            Car car = CarStorage.Cars[cmbCars.SelectedIndex];
            decimal total = car.Price * days;

            if (chkInsurance.Checked)
            {
                total = total + total * 15 / 100;
            }

            lblResult.Text = "Стоимость аренды: " + total + " руб.";
        }

        // кнопка «ОФОРМИТЬ» — запись аренды в список
        private void btnAddRent_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите автомобиль");
                return;
            }
            if (lblResult.Text == "")
            {
                MessageBox.Show("Сначала рассчитайте стоимость аренды");
                return;
            }

            string row = dtpStart.Value.ToShortDateString() + " · " +
                cmbCars.Text + " · " + numDays.Value + " дн. · " +
                lblResult.Text.Replace("Стоимость аренды: ", "");

            CarStorage.Rents.Add(row);
            lstRents.Items.Add(row);
        }

        // кнопка «ОЧИСТИТЬ» — удаление всех оформленных аренд
        private void btnClearRents_Click(object sender, EventArgs e)
        {
            CarStorage.Rents.Clear();
            lstRents.Items.Clear();
        }

        // кнопка «НАЗАД» — возврат в главное меню
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
