using Hospital.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;
using System.IO;
using System.Windows;

namespace Hospital
{
    public partial class App : Application
    {

        public static IHost? AppHost { get; private set; }
        public static IConfigurationRoot configuration;
        private ServiceCollection serviceCollection;
        public static ServiceProvider ServiceProvider;

        public App()
        {

            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) => {
                    //services.AddSingleton<idoct, ItemGroupService>();
                    services.AddSingleton<Login>();
                }).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
             


            var startupWindow = AppHost.Services.GetRequiredService<Login>();

            if (startupWindow != null)
            {
                startupWindow.Show();
            }

            base.OnStartup(e);
        }

        
        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }



    }
}
