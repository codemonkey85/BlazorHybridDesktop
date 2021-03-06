using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.MobileBlazorBindings;
using System.Net.Http;
using Xamarin.Forms;
using System;

namespace BlazorHybridDesktop
{
    public class App : Application
    {
        public App(IFileProvider fileProvider = null)
        {
            IHostBuilder hostBuilder = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Adds web-specific services such as NavigationManager
                    services.AddBlazorHybrid();

                    // Register app-specific services
                    services.AddSingleton<TodosState>();

                    services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/") });
                })
                .UseWebRoot("wwwroot");

            if (fileProvider != null)
            {
                hostBuilder.UseStaticFiles(fileProvider);
            }
            else
            {
                hostBuilder.UseStaticFiles();
            }
            IHost host = hostBuilder.Build();

            MainPage = new ContentPage { Title = GlobalConstants.AppName };
            host.AddComponent<Main>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
