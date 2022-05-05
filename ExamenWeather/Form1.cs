using AppCore.IServices;
using AppCore.Services;
using Common;
using Domain.Entities;
using Infraestructure.OpenWeatherClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWeather
{
    public partial class Form1 : Form
    {
        string saveJson;
        public static string filename = "saveClima.json";
        string ciudad;
        double x, y;
        long dt = DateTimeOffset.Now.ToUnixTimeSeconds();
        //public OpenWeather openWeather;
        public WeatherForeCast.ForeCastInfo wfc;
        public OpenWeatherWeb opw;
        public List <coordenadas> cd;
        public IweatherServices weatherServices;
        public Form1(IweatherServices WeatherServices)
        {
            this.weatherServices = WeatherServices;
            opw = new OpenWeatherWeb();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ciudad = cmbCity.SelectedItem.ToString();
                flpContent.Controls.Clear();
                Task.Run(Request).Wait();
                
                x = cd[0].lat;
                y = cd[0].lon;
                Task.Run(Request2).Wait();
                if (wfc == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpenWeather.");
                }
                double temp = wfc.current.temp - 273.15;
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                DateTime day1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                lblCity.Text = ciudad;
                lblTemp.Text = (int)temp+ "C";
                lblDetails.Text = wfc.current.weather[0].description;
                day = day.AddSeconds(wfc.current.sunrise).ToLocalTime();
                lblAm.Text = day.ToShortTimeString();
                day1 = day1.AddSeconds(wfc.current.sunset).ToLocalTime();
                lblAt.Text = day1.ToShortTimeString();
                lblWinS.Text = wfc.current.wind_speed.ToString() + " Km/h";
                lblPress.Text = wfc.current.pressure.ToString();
                lblHumm.Text = wfc.current.humidity.ToString() + "%";
                lblVis.Text = wfc.current.visibility.ToString();
                lblWeather.Text = wfc.current.weather[0].main;
                WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + wfc.current.weather[0].icon + ".png";
                MiniDetail mini;
                for (int i = 0; i < wfc.hourly.Count; i++)
                {
                    double tempdls;
                    int tempint;
                    string hoursstring;
                    tempdls = wfc.hourly[i].temp - 273.15;
                    hoursstring = ConvertDateTime(wfc.hourly[i].dt).ToShortTimeString();
                    tempint = (int)tempdls;
                    mini = new MiniDetail();
                    mini.label1.Text = hoursstring;
                    mini.label2.Text = wfc.hourly[i].weather[0].main;
                    mini.label3.Text = wfc.hourly[i].weather[0].description;
                    mini.label4.Text = wfc.hourly[i].wind_speed.ToString();
                    mini.label5.Text = wfc.hourly[i].pressure.ToString();
                    mini.lblTemp.Text = tempint.ToString() + "C";
                    mini.WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + wfc.hourly[i].weather[0].icon + ".png";
                    flpContent.Controls.Add(mini);
                }
                saveJson = JsonConvert.SerializeObject(wfc, Formatting.Indented);
                File.WriteAllText(filename, saveJson);
                WeatherForeCast.ForeCastInfo foreCastInfo = new WeatherForeCast.ForeCastInfo()
                {
                    current = wfc.current,
                    hourly = wfc.hourly
                };
                weatherServices.Add(foreCastInfo);
           

            }
            catch (Exception)
            {

               
            }
        }
        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddSeconds(Milisec).ToLocalTime();

            return day;
        }
        public async Task Request()
        {
            cd = await opw.GetLatLong(ciudad);
        }
        public async Task Request2()
        {
            wfc = await opw.GetWeatherByGeo(x,y,dt);
        }

        public static string GetClimaJsonFromFile()
        {
            string climaJsonFromFile;
            using (var reader = new StreamReader(filename))
                climaJsonFromFile = reader.ReadToEnd();
            return climaJsonFromFile;
        }
        public void getWeatherFromJson()
        {
            WeatherForeCast.ForeCastInfo openJson = JsonConvert.DeserializeObject<WeatherForeCast.ForeCastInfo>(GetClimaJsonFromFile());
            double temp = openJson.current.temp - 273.15;
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            DateTime day1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            lblCity.Text = ciudad;
            lblTemp.Text = (int)temp + "C";
            lblDetails.Text = openJson.current.weather[0].description;
            day = day.AddSeconds(openJson.current.sunrise).ToLocalTime();
            lblAm.Text = day.ToShortTimeString();
            day1 = day1.AddSeconds(openJson.current.sunset).ToLocalTime();
            lblAt.Text = day1.ToShortTimeString();
            lblWinS.Text = openJson.current.wind_speed.ToString() + " Km/h";
            lblPress.Text = openJson.current.pressure.ToString();
            lblHumm.Text = openJson.current.humidity.ToString() + "%";
            lblVis.Text = openJson.current.visibility.ToString();
            lblWeather.Text = openJson.current.weather[0].main;
            WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + openJson.current.weather[0].icon + ".png";
            MiniDetail mini;
            for (int i = 0; i < openJson.hourly.Count; i++)
            {
                double tempdls;
                int tempint;
                string hoursstring;
                tempdls = openJson.hourly[i].temp - 273.15;
                hoursstring = ConvertDateTime(openJson.hourly[i].dt).ToShortTimeString();
                tempint = (int)tempdls;
                mini = new MiniDetail();
                mini.label1.Text = hoursstring;
                mini.label2.Text = openJson.hourly[i].weather[0].main;
                mini.label3.Text = openJson.hourly[i].weather[0].description;
                mini.label4.Text = openJson.hourly[i].wind_speed.ToString();
                mini.label5.Text = openJson.hourly[i].pressure.ToString();
                mini.lblTemp.Text = tempint.ToString() + "C";
                mini.WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + openJson.hourly[i].weather[0].icon + ".png";
                flpContent.Controls.Add(mini);
            }
        }

            private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = Encoding.UTF8.GetString(Properties.Resources.NicaraguaCitys);
            List<Citys> Ciudades = new List<Citys>();
            Ciudades = JsonConvert.DeserializeObject<List<Citys>>(json);
            cmbCity.DataSource = Ciudades.Select(x => x.City).ToList();
        }
    }
    }


