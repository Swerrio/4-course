using System.Collections.Generic;

namespace SquareMeter.Models
{
    // Данные главной страницы, которые контроллер передаёт в представление
    public class HomeViewModel
    {
        public IList<Advantage> Advantages { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Property> Featured { get; set; }
        public int TotalCount { get; set; }
        public int CityCount { get; set; }
    }

    // Данные страницы каталога
    public class CatalogViewModel
    {
        public IList<Property> Items { get; set; }
        public IList<Category> Categories { get; set; }
        public string SelectedKey { get; set; }
        public string SelectedTitle { get; set; }
    }

    // Страница одного объекта и похожие предложения
    public class PropertyViewModel
    {
        public Property Item { get; set; }
        public Category Category { get; set; }
        public IList<Property> Similar { get; set; }
    }

    // Страница ошибки и страница «не найдено»
    public class StatusViewModel
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string RequestId { get; set; }
    }
}
