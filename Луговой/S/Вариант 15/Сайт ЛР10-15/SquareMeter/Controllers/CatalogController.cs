using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SquareMeter.Data;
using SquareMeter.Models;

namespace SquareMeter.Controllers
{
    // Каталог объектов. В ЛР №10 это демонстрационный раздел,
    // полноценные функции появятся в следующих работах.
    public class CatalogController : Controller
    {
        // /Catalog и /Catalog?category=flats; неизвестный раздел = все объекты
        public IActionResult Index(string category)
        {
            Category selected = DemoCatalog.FindCategory(category);
            CatalogViewModel model = new CatalogViewModel
            {
                Categories = DemoCatalog.Categories(),
                Items = DemoCatalog.ByCategory(category),
                SelectedKey = selected?.Key,
                SelectedTitle = selected == null ? "Все объекты" : selected.Title
            };
            return View(model);
        }

        // /catalog/3: страница одного объекта; нет такого объекта = страница 404
        public IActionResult Details(int id)
        {
            Property item = DemoCatalog.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            PropertyViewModel model = new PropertyViewModel
            {
                Item = item,
                Category = DemoCatalog.FindCategory(item.CategoryKey),
                Similar = DemoCatalog.All().Where(p => p.Id != id).Take(3).ToList()
            };
            return View(model);
        }
    }
}
