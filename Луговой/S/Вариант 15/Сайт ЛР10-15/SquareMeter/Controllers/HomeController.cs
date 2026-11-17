using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SquareMeter.Data;
using SquareMeter.Models;

namespace SquareMeter.Controllers
{
    // Главная страница, «О проекте», «Контакты» и служебные страницы ошибок
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Advantages = DemoCatalog.Advantages(),
                Categories = DemoCatalog.Categories(),
                Featured = DemoCatalog.Featured(),
                TotalCount = DemoCatalog.All().Count,
                CityCount = DemoCatalog.All().Select(p => p.City).Distinct().Count()
            };
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        // Непредвиденная ошибка на сервере: запись в журнал и понятная страница
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            IExceptionHandlerPathFeature failure =
                HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (failure != null)
            {
                logger.LogError(failure.Error, "Ошибка при обработке {Path}", failure.Path);
            }

            Response.StatusCode = 500;
            return View("Status", new StatusViewModel
            {
                Code = 500,
                Title = "Что-то пошло не так",
                Message = "Мы уже знаем о проблеме. Попробуйте обновить страницу или вернитесь на главную.",
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }

        // Неизвестный адрес и другие коды ответа
        public IActionResult Status(int id)
        {
            StatusViewModel model = new StatusViewModel { Code = id };
            if (id == 404)
            {
                model.Title = "Страница не найдена";
                model.Message = "Возможно, объект уже продан или адрес набран с ошибкой. " +
                    "Посмотрите другие предложения в каталоге.";
            }
            else
            {
                model.Title = "Запрос не выполнен";
                model.Message = "Сервер вернул код " + id + ". Попробуйте вернуться на главную страницу.";
            }
            return View(model);
        }
    }
}
