using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.OpenWeatherClient
{
    public class BinaryWeatherRepository : IWeatherModel
    {
        public RAFContext context;
        public const int SIZE = 100;
        public BinaryWeatherRepository()
        {
            context = new RAFContext("WeatherForeCast", SIZE);
        }
        public void Add(WeatherForeCast.ForeCastInfo t)
        {
            try
            {
                context.Create<WeatherForeCast.ForeCastInfo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(WeatherForeCast.ForeCastInfo t)
        {
            try
            {
                context.Delete<WeatherForeCast.ForeCastInfo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public WeatherForeCast.ForeCastInfo GetById(int id)
        {

            try
            {
                return context.Get<WeatherForeCast.ForeCastInfo>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<WeatherForeCast.ForeCastInfo> Read()
        {

            try
            {
                return context.GetAll<WeatherForeCast.ForeCastInfo>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(WeatherForeCast.ForeCastInfo t)
        {
            try
            {
                context.Update<WeatherForeCast.ForeCastInfo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
