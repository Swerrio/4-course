using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarCardForm : Form
    {
        private Car car;

        public CarCardForm(Car selected, Image photo)
        {
            InitializeComponent();
            car = selected;
            picPhoto.Image = photo;
            ShowCar();
        }

        // вывод данных выбранного автомобиля в карточку
        private void ShowCar()
        {
            lblName.Text = car.Brand + " " + car.Model;
            lblBrandVal.Text = car.Brand;
            lblModelVal.Text = car.Model;
            lblTypeVal.Text = car.Type;
            lblPriceVal.Text = car.Price + " руб.";
            lblWeekVal.Text = car.Price * 7 + " руб.";
        }

        // кнопка «СФОРМИРОВАТЬ ДОКУМЕНТ»
        private void btnWord_Click(object sender, EventArgs e)
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "АвтоПрокат");
            Directory.CreateDirectory(folder);

            string name = "Карточка_" + car.Brand + "_" + car.Model + ".docx";
            name = name.Replace(" ", "_");
            foreach (char bad in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(bad, '_');
            }
            string path = Path.Combine(folder, name);

            try
            {
                WordExporter.CreateCarCard(car, picPhoto.Image, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сформировать документ: " +
                    ex.Message);
                return;
            }

            lblSaved.Text = "Документ сохранён: " + path;
            MessageBox.Show("Документ сформирован:" + Environment.NewLine +
                path);
        }

        // кнопка «ЗАКРЫТЬ»
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
