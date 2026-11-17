using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SquareMeter
{
    // Точка входа веб-приложения: создаёт веб-сервер Kestrel
    // и передаёт настройку сайта классу Startup
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();

            // При запуске для разработки сайт сам открывает браузер.
            // Так страница появляется в любой версии Visual Studio и при
            // запуске командой dotnet run, даже если профиль запуска не применился.
            IWebHostEnvironment env = host.Services.GetRequiredService<IWebHostEnvironment>();
            IHostApplicationLifetime lifetime = host.Services.GetRequiredService<IHostApplicationLifetime>();
            if (env.IsDevelopment() &&
                Environment.GetEnvironmentVariable("SQUAREMETER_NO_BROWSER") != "1")
            {
                lifetime.ApplicationStarted.Register(() => OpenBrowser(host));
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void OpenBrowser(IHost host)
        {
            try
            {
                IServer server = host.Services.GetRequiredService<IServer>();
                string url = server.Features.Get<IServerAddressesFeature>()?.Addresses.FirstOrDefault()
                    ?? "http://localhost:5080";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception)
            {
                // браузер не открылся: адрес сайта всё равно виден в окне консоли
            }
        }
    }
}
