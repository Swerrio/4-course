namespace SquareMeter.Models
{
    // Раздел каталога: квартиры, дома, новостройки, коммерческая недвижимость
    public class Category
    {
        public string Key { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
        public int Count { get; set; }
    }

    // Преимущество сервиса для блока на главной странице
    public class Advantage
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
