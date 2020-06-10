using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;

namespace Eindopdracht_Weerstation_Mark_Benjamins
{
    public partial class Form1 : Form
    {
        int interval = 60;
        string cityName = "Emmen";

        public Form1()
        {
            // splash screen
            Thread t = new Thread(new ThreadStart(startSplashScreen));
            t.Start();
            Thread.Sleep(5000);

            // load defauld form
            InitializeComponent();

            // laad icon in taskbar
            ShowInTaskbar = true;

            // laat de weersvoorspelling
            GetWeather(cityName);

            // start timer interval
            timer1.Interval = interval * 1000;

            // stelt input gelijk aan de var
            inputInterval.Text = string.Format("{0}", interval);
            // steld city name gelijk aan de var
            inputPlaats.Text = string.Format("{0}", cityName);

            //stop splash screen
            t.Abort();
        }

        public void startSplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        void GetWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string Url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=379ed7569bbd526bc8cd08d144c26fd7&units=metric&cnt=6", city);
                var JSon = web.DownloadString(Url);
                var Result = JsonConvert.DeserializeObject<WeerInfo.Root>(JSon);
                WeerInfo.Root output = Result;
                string WindDir = GetWindDirection(output.wind.deg);
                var updateTime = DateTime.Now;

                double Temp = 0.0;
                string Symbol = "";
                if (C.Checked == true)
                {
                    Temp = output.main.temp;
                    Symbol = "°C";
                }
                else if (F.Checked == true)
                {
                    Temp = output.main.temp * 1.8 + 32;
                    Symbol = "°F";
                }
                else
                {
                    Temp = 404;
                    Symbol = "Error";
                }

                plaats.Text = string.Format("{0}, {1}", output.name, output.sys.country);
                Tempera.Text = string.Format("Temperatuur: {0} {1}", Temp, Symbol);
                Luchtvochtigheid.Text = string.Format("Luchtvochtigheid: {0} %", output.main.humidity);
                Wind.Text = string.Format("Wind: {0} met {1} Km/h", WindDir, output.wind.speed);
                time.Text = string.Format("[Last update] {0:HH:mm:ss}", updateTime);
                timer1.Interval = interval * 1000;
                huidigeTemperatuurToolStripMenuItem.Text = string.Format("Temperatuur: {0} {1}", Temp, Symbol);
            }
        }

        private string GetWindDirection(double deg)
        {
            // bepaald de output van de windrichting
            string WindString = "";
            if (deg >= 336.5 && deg < 22.5)
            {
                WindString += "Noorderwind";
            }
            else if (deg >= 22.5 && deg < 67.5)
            {
                WindString += "Noordoosterwind";
            }
            else if (deg >= 67.5 && deg < 112.5)
            {
                WindString += "Oosterwind";
            }
            else if (deg >= 112.5 && deg < 157.5)
            {
                WindString += "Zuidoosterwind";
            }
            else if (deg >= 157.5 && deg < 202.5)
            {
                WindString += "Zuiderwind";
            }
            else if (deg >= 202.5 && deg < 247.5)
            {
                WindString += "Zuidwesterwind";
            }
            else if (deg >= 247.5 && deg < 292.5)
            {
                WindString += "Westerwind";
            }
            else
            {
                WindString += "Noordwesterwind";
            }
            return WindString;
        }

        // icon rechts onder in (tray icon)
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        // opties in de tray icon optie menu
        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // laat de about form in
            About about = new About();
            about.ShowDialog();
        }
        private void optiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // go to form1 optie menu
            Visible = true;
            tabControl1.SelectedIndex = 2;
        }

        private void sluitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sluit de applicatie
            Environment.Exit(1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open form 1
            Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // als je op X drukt sluit de applicatie maar hij blijft aan staan.
            e.Cancel = true;
            Visible = false;
        }

        private void verversenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetWeather(cityName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cityName = inputPlaats.Text;
            this.interval = int.Parse(inputInterval.Text);
            GetWeather(cityName);
            tabControl1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetWeather(cityName);
        }
    }
}
