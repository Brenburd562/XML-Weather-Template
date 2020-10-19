using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            updateTime.Text = DateTime.Now.ToString();
            string I = "Last Update: " + DateTime.Now.ToString("dddd");
            int day1, day2, day3, day4, day5, day6, day7;

            labelSun.ForeColor = System.Drawing.Color.White;
            labelMon.ForeColor = System.Drawing.Color.White;
            labelTue.ForeColor = System.Drawing.Color.White;
            labelWed.ForeColor = System.Drawing.Color.White;
            labelThu.ForeColor = System.Drawing.Color.White;
            labelFri.ForeColor = System.Drawing.Color.White;
            labelSat.ForeColor = System.Drawing.Color.White;
            if (I == "Sunday")
            {
                labelSun.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 0;
                day2 = 1;
                day3 = 2;
                day4 = 3;
                day5 = 4;
                day6 = 5;
                day7 = 6;
            }
            else if (I == "Monday")
            {
                labelMon.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 6;
                day2 = 0;
                day3 = 1;
                day4 = 2;
                day5 = 3;
                day6 = 4;
                day7 = 5;
            }
            else if (I == "Tuesday")
            {
                labelTue.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 5;
                day2 = 6;
                day3 = 0;
                day4 = 1;
                day5 = 2;
                day6 = 3;
                day7 = 4;
            }
            else if (I == "Wednesday")
            {
                labelWed.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 4;
                day2 = 5;
                day3 = 6;
                day4 = 0;
                day5 = 1;
                day6 = 2;
                day7 = 3;
            }
            else if (I == "Thursday")
            {
                labelThu.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 3;
                day2 = 4;
                day3 = 5;
                day4 = 6;
                day5 = 0;
                day6 = 1;
                day7 = 2;
            }
            else if (I == "Friday")
            {
                labelFri.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 2;
                day2 = 3;
                day3 = 4;
                day4 = 5;
                day5 = 6;
                day6 = 0;
                day7 = 1;
            }
            else
            {
                labelSat.ForeColor = System.Drawing.Color.SeaGreen;
                day1 = 1;
                day2 = 2;
                day3 = 3;
                day4 = 4;
                day5 = 5;
                day6 = 6;
                day7 = 0;
            }

            date1.Text = Form1.days[0].date;
            min1.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("00") + "°c";
            max1.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("00") + "°c";
            curTemp.Text = Convert.ToDouble(Form1.days[0].tempAvg).ToString("00") + "°";

            minSun.Text = Convert.ToDouble(Form1.days[day1].tempLow).ToString("00") + "°c";
            maxSun.Text = Convert.ToDouble(Form1.days[day1].tempHigh).ToString("00") + "°c";

            minMon.Text = Convert.ToDouble(Form1.days[day2].tempLow).ToString("00") + "°c";
            maxMon.Text = Convert.ToDouble(Form1.days[day2].tempHigh).ToString("00") + "°c";

            minTue.Text = Convert.ToDouble(Form1.days[day3].tempLow).ToString("00") + "°c";
            maxTue.Text = Convert.ToDouble(Form1.days[day3].tempHigh).ToString("00") + "°c";

            minWed.Text = Convert.ToDouble(Form1.days[day4].tempLow).ToString("00") + "°c";
            maxWed.Text = Convert.ToDouble(Form1.days[day4].tempHigh).ToString("00") + "°c";

            minThu.Text = Convert.ToDouble(Form1.days[day5].tempLow).ToString("00") + "°c";
            maxThu.Text = Convert.ToDouble(Form1.days[day5].tempHigh).ToString("00") + "°c";

            minFri.Text = Convert.ToDouble(Form1.days[day6].tempLow).ToString("00") + "°c";
            maxFri.Text = Convert.ToDouble(Form1.days[day6].tempHigh).ToString("00") + "°c";

            minSat.Text = Convert.ToDouble(Form1.days[day7].tempLow).ToString("00") + "°c";
            maxSat.Text = Convert.ToDouble(Form1.days[day7].tempHigh).ToString("00") + "°c";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
