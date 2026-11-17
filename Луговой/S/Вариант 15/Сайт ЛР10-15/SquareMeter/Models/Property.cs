using System.Globalization;

namespace SquareMeter.Models
{
    // Объект недвижимости: квартира, дом, помещение
    public class Property
    {
        private static readonly CultureInfo Ru = new CultureInfo("ru-RU");

        public int Id { get; set; }
        public string Title { get; set; }
        public string CategoryKey { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public decimal Price { get; set; }
        public double Area { get; set; }
        public int Rooms { get; set; }
        public string Floor { get; set; }
        public string Image { get; set; }
        public string Badge { get; set; }
        public string Description { get; set; }
        public bool IsFeatured { get; set; }

        // Цена в рублях с разделением разрядов: «12 500 000 ₽»
        public string PriceText
        {
            get { return Price.ToString("N0", Ru) + " ₽"; }
        }

        public string PricePerMeter
        {
            get
            {
                if (Area <= 0) return "";
                return (Price / (decimal)Area).ToString("N0", Ru) + " ₽/м²";
            }
        }

        public string AreaText
        {
            get { return Area.ToString("0.#", Ru) + " м²"; }
        }

        public string RoomsText
        {
            get
            {
                if (Rooms <= 0) return "Свободная планировка";
                if (Rooms == 1) return "1 комната";
                if (Rooms < 5) return Rooms + " комнаты";
                return Rooms + " комнат";
            }
        }
    }
}
