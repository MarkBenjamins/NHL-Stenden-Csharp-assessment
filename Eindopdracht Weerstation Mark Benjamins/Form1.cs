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


namespace Eindopdracht_Weerstation_Mark_Benjamins
{

    public partial class Form1 : Form
    {
        //const string APPID
        string cityName = "Emmen,nl";

        public Form1()
        {
            // splash screen
            Thread t = new Thread(new ThreadStart(startSplashScreen));
            t.Start();
            Thread.Sleep(5000);

            // load defauld form
            InitializeComponent();

            //stop splash screen
            t.Abort();

            ShowInTaskbar = true;
            GetWeather(cityName);
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

                plaats.Text = string.Format("{0}, {1}", output.name, output.sys.country);
                Temp.Text = string.Format("Temperatuur: {0} ℃", output.main.temp);
                Luchtvochtigheid.Text = string.Format("Luchtvochtigheid: {0} %", output.main.humidity);
                Wind.Text = string.Format("Wind: {0} met {1} Km/h", WindDir, output.wind.speed);
                huidigeTemperatuurToolStripMenuItem.Text = string.Format("Temperatuur: {0} ℃", output.main.temp);
            }
        }

        private string GetWindDirection(double deg)
        {
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

        private void Actueel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Trend_Click(object sender, EventArgs e)
        {

        }

        // icon rechts onder in (tray icon)
        private void Form1_load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Weer applicatie C#";
            notifyIcon1.BalloonTipText = "Weer applicatie gestart";
            notifyIcon1.Text = "Weer applicatie C#";
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        // opties in de tray icon optie menu
        private void huidigeTemperatuurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dispaly temperatuur van het moment
        }
        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            // minemize of wel is closed open
            Visible = true;
        }

        private void Actueel_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void Opties_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
