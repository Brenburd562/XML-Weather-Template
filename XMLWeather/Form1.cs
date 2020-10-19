using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");


            while (reader.Read())
            {
                //create a day object
                Day d = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.weatherType = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                d.tempAvg = reader.GetAttribute("day");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");
        


                //TODO: if day object not null add to the days list
                days.Add(d);
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            //string I = "http://api.openweathermap.org/data/2.5/weather?q=" + "Stratford" + "," + "CA" + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0"; /////////////////////////////READ ME: This was going to be how you were going to be able to choose the area for the weather but due to using the files I cannot do this. there was going to be a text box that you would input both a city and a country that would then replace the bit that says stratford/CA through a variable.
            XmlReader reader = XmlReader.Create("WeatherData.xml");

            //TODO: find the city and current temperature and add to appropriate item in days list

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
        }


    }
}
