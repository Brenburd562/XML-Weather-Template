using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility, tempAvg, weatherType;

        public Day()
        {
            date = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = tempAvg = weatherType = "";
        }
    }
}
