namespace CarRental;

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
            lstCars.Items.Add($"{car.Brand} {car.Model} — {car.Price} руб.");
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

    private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
