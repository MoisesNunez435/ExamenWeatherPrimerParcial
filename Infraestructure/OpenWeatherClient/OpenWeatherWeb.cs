using Common;
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.OpenWeatherClient
{
    public class OpenWeatherWeb : IOpenWeatherWeb
    {
        public async Task<WeatherForeCast.ForeCastInfo> GetWeatherByGeo(double x, double y,long dt)
        {

            string url = $"{AppSettings.ApiUrl}lat={x}&lon={y}&dt={dt}&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherForeCast.ForeCastInfo>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<List<coordenadas>> GetLatLong(string city)
        {

            string url = $"{AppSettings.ApiUrlGeo}{city}&limit=1&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {

                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }
                List<coordenadas> crd = new List<coordenadas>();
                crd = JsonConvert.DeserializeObject<List<coordenadas>>(jsonObject);
                return crd;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
