using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.OpenWeatherClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWeather
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterType<BinaryWeatherRepository>().As<IWeatherModel>();
            builder.RegisterType<WeatherServices>().As<IweatherServices>();
            var container = builder.Build();
            Application.Run(new Form1(container.Resolve<IweatherServices>()));


        }
    }
}
