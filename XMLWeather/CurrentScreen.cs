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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            updateTime.Text = "Last Update: " + DateTime.Now.ToString();
            cityOutput.Text = Form1.days[0].location;
            date1.Text = Form1.days[0].date;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].tempAvg).ToString("00") + "°";
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("00") + "°c";
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("00") + "°c";
            labelWeatherType.Text = Form1.days[0].weatherType;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

    }
}
