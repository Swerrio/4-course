using System.Collections.Generic;

namespace CarRental
{
    // Общий список автомобилей и оформленных аренд.
    // Данные хранятся в одном месте, чтобы все окна приложения
    // работали с одним и тем же автопарком.
    public static class CarStorage
    {
        public static List<Car> Cars = new List<Car>();
        public static List<string> Rents = new List<string>();

        // Начальное заполнение каталога
        public static void LoadDemoData()
        {
            if (Cars.Count > 0)
            {
                return;
            }

            Add("Toyota", "Camry", 3500, "Бизнес");
            Add("Kia", "Rio", 1800, "Эконом");
            Add("Skoda", "Octavia", 2400, "Комфорт");
            Add("Toyota", "Land Cruiser", 6200, "Внедорожник");
            Add("Lada", "Granta", 1200, "Эконом");
        }

        private static void Add(string brand, string model,
            decimal price, string type)
        {
            Car car = new Car();
            car.Brand = brand;
            car.Model = model;
            car.Price = price;
            car.Type = type;
            Cars.Add(car);
        }
    }
}
