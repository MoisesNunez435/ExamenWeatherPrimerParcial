using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Infraestructure.OpenWeatherClient;
using Common;
using AppCore.Services;
using AppCore.IServices;

namespace ExamenWeather
{
    public partial class WeatherPanel : UserControl
    {
        public WeatherForeCast.ForeCastInfo wfc2;
        public OpenWeatherWeb opw;
        public List<coordenadas> cd;
        public double x, y;
        long dt = DateTimeOffset.Now.ToUnixTimeSeconds();
        public IweatherServices weatherServices;
        public WeatherPanel(IweatherServices WeatherServices)
        {
            this.weatherServices = WeatherServices;
            opw = new OpenWeatherWeb();
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            Task.Run(Request).Wait();
            Task.Run(Request2).Wait();
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            DateTime day1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            
            DetailControl detailsWeather = new DetailControl();
            detailsWeather.lblDetail.Text = "Details";
            detailsWeather.lblValue.Text = wfc2.current.weather[0].description;
            flpContent.Controls.Add(detailsWeather);

            DetailControl detailsWeather1 = new DetailControl();
            detailsWeather1.lblDetail.Text = "amanecer";
            day = day.AddSeconds(wfc2.current.sunrise).ToLocalTime();
            detailsWeather1.lblValue.Text = day.ToShortTimeString();
            flpContent.Controls.Add(detailsWeather1);

            DetailControl detailsWeather2 = new DetailControl();
            detailsWeather2.lblDetail.Text = "atardecer";
            day1 = day1.AddSeconds(wfc2.current.sunset).ToLocalTime();
            detailsWeather2.lblValue.Text = day1.ToShortTimeString();
            flpContent.Controls.Add(detailsWeather2);

            DetailControl detailsWeather3 = new DetailControl();
            detailsWeather3.lblDetail.Text = "Wind Speed";
            detailsWeather3.lblValue.Text = wfc2.current.wind_speed.ToString() + " Km/h";
            flpContent.Controls.Add(detailsWeather3);

            DetailControl detailsWeather4 = new DetailControl();
            detailsWeather4.lblDetail.Text = "Pressure";
            detailsWeather4.lblValue.Text = wfc2.current.pressure.ToString();
            flpContent.Controls.Add(detailsWeather4);

            DetailControl detailsWeather5 = new DetailControl();
            detailsWeather5.lblDetail.Text = "Humidity";
            detailsWeather5.lblValue.Text = wfc2.current.humidity.ToString() + "%";
            flpContent.Controls.Add(detailsWeather5);

            DetailControl detailsWeather6 = new DetailControl();
            detailsWeather6.lblDetail.Text = "Visibility";
            detailsWeather6.lblValue.Text = wfc2.current.visibility.ToString();
            flpContent.Controls.Add(detailsWeather6);

            MiniDetail mini;
            for (int i=0; i < 5; i++)
            {
                double temp;
                int tempint;
                string hoursstring;
                temp = wfc2.hourly[i].temp - 273.15;
                hoursstring = ConvertDateTime(wfc2.hourly[i].dt).ToShortTimeString();
                tempint = (int)temp;
                mini = new MiniDetail();
                mini.label1.Text = hoursstring;
                mini.label2.Text = wfc2.hourly[i].weather[0].main;
                mini.label3.Text = wfc2.hourly[i].weather[0].description;
                mini.label4.Text = wfc2.hourly[i].wind_speed.ToString();
                mini.label5.Text = wfc2.hourly[i].pressure.ToString();
                mini.lblTemp.Text = tempint.ToString()+"C";
                mini.WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + wfc2.hourly[i].weather[0].icon + ".png";
                flpContent2.Controls.Add(mini);
            }
            WeatherForeCast.ForeCastInfo foreCastInfo = new WeatherForeCast.ForeCastInfo()
            {
                current = wfc2.current,
                hourly = wfc2.hourly
            };
            weatherServices.Add(foreCastInfo);
        }

        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddSeconds(Milisec).ToLocalTime();

            return day;
        }
        public async Task Request()
        {
            cd = await opw.GetLatLong(lblCity.Text);
        }
        public async Task Request2()
        {
            wfc2 = await opw.GetWeatherByGeo(x, y, dt);
        }
    }
}
