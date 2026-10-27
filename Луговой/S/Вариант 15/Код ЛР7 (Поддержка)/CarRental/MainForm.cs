using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CarStorage.LoadDemoData();
            ShowCatalogCount();
        }

        private void ShowCatalogCount()
        {
            lblStatus.Text = "Автомобилей в каталоге: " + CarStorage.Cars.Count;
        }

        // переход в раздел «Автомобили»
        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm form = new CarsForm();
            form.ShowDialog();
            ShowCatalogCount();
        }

        // переход в раздел «Аренда»
        private void btnRent_Click(object sender, EventArgs e)
        {
            RentForm form = new RentForm();
            form.ShowDialog();
        }

        // поиск автомобиля по марке, результат — в информационной области
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Введите марку автомобиля для поиска");
                return;
            }

            lstInfo.Items.Clear();
            int count = 0;

            foreach (Car car in CarStorage.Cars)
            {
                if (car.Brand == txtSearch.Text)
                {
                    lstInfo.Items.Add(car.Brand + " " + car.Model + " — " +
                        car.Price + " руб./сутки — " + car.Type);
                    count++;
                }
            }

            if (count == 0)
            {
                lstInfo.Items.Add("По запросу «" + txtSearch.Text +
                    "» ничего не найдено");
            }

            lblStatus.Text = "Найдено автомобилей: " + count;
        }

        // кнопка «ВЫХОД» — закрытие главного окна
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
