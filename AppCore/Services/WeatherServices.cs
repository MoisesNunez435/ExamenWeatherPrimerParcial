using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class WeatherServices : BaseServices<WeatherForeCast.ForeCastInfo>, IweatherServices
    {
        IWeatherModel weatherModel;
        public WeatherServices(IWeatherModel model) : base(model)
        {
            this.weatherModel = model;
        }
        public WeatherForeCast.ForeCastInfo GetById(int id)
        {
            return weatherModel.GetById(id);
        }
    }
}
