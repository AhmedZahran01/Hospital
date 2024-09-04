using Hospital.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Om_El_Masryeen_Hospital.Repositories.Repo_Classes;
using Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces;
using System;
using System.Globalization;
using System.Windows;

namespace Hospital
{
    public partial class App : Application
    {

        public static IHost? AppHost { get; private set; }


        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) => {
                    services.AddSingleton<IDoctorRepo, DoctorRepo>();
                     
                }).Build();
        }

    }
}
