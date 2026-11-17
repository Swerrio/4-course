using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.WebEncoders;

namespace SquareMeter
{
    // Настройка сервисов и конвейера обработки запросов
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Русский текст выводится в HTML как есть, а не кодами &#x...;
            services.Configure<WebEncoderOptions>(options =>
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Ошибки всегда показываются страницей сайта, а не технической
            // страницей с текстом исключения: так сайт ведёт себя одинаково
            // при запуске из Visual Studio и без неё. Подробности пишутся в журнал.
            app.UseExceptionHandler("/Home/Error");

            // Неизвестный адрес (404) и другие коды ответа: своя страница
            app.UseStatusCodePagesWithReExecute("/Home/Status/{0}");

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "property",
                    pattern: "catalog/{id:int}",
                    defaults: new { controller = "Catalog", action = "Details" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
