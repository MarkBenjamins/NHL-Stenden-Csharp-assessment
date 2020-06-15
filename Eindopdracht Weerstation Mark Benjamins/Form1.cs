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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Eindopdracht_Weerstation_Mark_Benjamins
{
    public partial class Form1 : Form
    {
        // Var voor de default interval
        int interval = 60;
        // var voor de default plaats
        string cityName = "Nieuweroord";
        string unit = "metric";

        public Form1()
        {
            // splash screen
            Thread t = new Thread(new ThreadStart(startSplashScreen));
            t.Start();
            Thread.Sleep(5000);

            // load defauld form
            this.InitializeComponent();

            // laad icon in taskbar
            this.ShowInTaskbar = true;

            // laat de weersvoorspelling
            this.GetWeather(cityName);

            // laat de voorspelling in de chart
            this.GetForecast(cityName);

            // start timer interval
            this.timer1.Interval = interval * 1000;

            // stelt input gelijk aan de var
            this.inputInterval.Text = string.Format("{0}", interval);
            // steld city name gelijk aan de var
            this.inputPlaats.Text = string.Format("{0}", cityName);

            //stop splash screen
            t.Abort();

            //Get infomation out DB
            this.DBplaceholder();
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
                if (this.C.Checked == true)
                {
                    Temp = output.main.temp;
                    Symbol = "°C";
                }
                else if (this.F.Checked == true)
                {
                    Temp = output.main.temp * 1.8 + 32;
                    Symbol = "°F";
                }
                else
                {
                    Temp = 404;
                    Symbol = "Error";
                }

                this.plaats.Text = string.Format("{0}, {1}", output.name, output.sys.country);
                this.Tempera.Text = string.Format("Temperatuur: {0} {1}", Temp, Symbol);
                this.Luchtvochtigheid.Text = string.Format("Luchtvochtigheid: {0} %", output.main.humidity);
                this.Wind.Text = string.Format("Wind: {0} met {1} Km/h", WindDir, output.wind.speed);
                this.time.Text = string.Format("[Last update] {0:HH:mm:ss}", updateTime);
                this.timer1.Interval = interval * 1000;
                this.huidigeTemperatuurToolStripMenuItem.Text = string.Format("Temperatuur: {0} {1}", Temp, Symbol);
                this.Voorspelling.Text = string.Format("{0}", output.weather[0].description);
                var myImage = output.weather[0].icon;
                this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(myImage);

            /// <summary>
            /// ****************************************************************
            ///                         Database connectie
            /// ****************************************************************
            /// </summary>

                // Insert Into - query

                // Initialize connection / command
                MySql.Data.MySqlClient.MySqlConnection conn;
                MySql.Data.MySqlClient.MySqlCommand cmd;

                conn = new MySql.Data.MySqlClient.MySqlConnection();
                cmd = new MySql.Data.MySqlClient.MySqlCommand();
                double toAdd = Temp;
                if (unit == "imperial")
                {
                    toAdd = ((toAdd * 1.8) + 32);
                }
                // Set connection / query
                conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";
                string myquerystring =
                    "INSERT INTO weerdata (plaats, temperatuur, tijdstip)" +
                    "VALUES(@cityName, @Temp, @updateTime)";

                // Check the connection and the query
                try
                {
                    // Open the connection and execute command (query)
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = myquerystring;

                    cmd.Parameters.AddWithValue("@cityName", cityName.ToString());
                    cmd.Parameters.AddWithValue("@Temp", toAdd);
                    cmd.Parameters.AddWithValue("@updateTime", updateTime.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Row Inserted into database successfully!",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Close connection
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    // Show error
                    MessageBox.Show(ex.Message);
                }

                // Update - query
                /*public void updateButton_Click(object sender, EventArgs e)
                {
                    // Initialize connection / command
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    MySql.Data.MySqlClient.MySqlCommand cmd;

                    conn = new MySql.Data.MySqlClient.MySqlConnection();
                    cmd = new MySql.Data.MySqlClient.MySqlCommand();

                    // Set connection / query
                    conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";
                    string myquerystring =
                        "UPDATE weerdata"+
                        "SET plaats='@cityName', temperatuur='@Temp', tijdstip = '@updateTime'"+
                        "WHERE id=1";


                    // Check the connection and the query
                    try
                    {
                        // Open the connection and execute command (query)
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = myquerystring;

                        cmd.Parameters.AddWithValue("@cityName", cityName.ToString());
                        cmd.Parameters.AddWithValue("@Temp", Temp.ToString());
                        cmd.Parameters.AddWithValue("@updateTime", updateTime.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Row(s) updated successfully!",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Close connection
                        conn.Close();

                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        // Show error
                        MessageBox.Show(ex.Message);
                    }
                }

                // Delete From - query
                public void deleteButton_Click(object sender, EventArgs e)
                {
                    // Initialize connection / command
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    MySql.Data.MySqlClient.MySqlCommand cmd;

                    conn = new MySql.Data.MySqlClient.MySqlConnection();
                    cmd = new MySql.Data.MySqlClient.MySqlCommand();

                    // Set connection / query
                    conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";
                    string myquerystring =
                        "DELETE FROM weerdata"+
                        "WHERE name='Hoogeveen'";

                    // Check the connection and the query
                    try
                    {
                        // Open the connection and execute command (query)
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = myquerystring;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Row(s) deleted successfully!",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Close connection
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        // Show error
                        MessageBox.Show(ex.Message);
                    }
                }*/
            ///
            ///         Eind DB connectie
            ///
            }
        }

    void GetForecast(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&units={1}&appid=379ed7569bbd526bc8cd08d144c26fd7", city, unit);
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<Forecast>(json);
                Forecast forecast = Object;
                DateTime LastUpdate = DateTime.Now;
            }
        }

        public void DBplaceholder()
        {
            MySqlConnection conn = new MySqlConnection();

            conn = new MySql.Data.MySqlClient.MySqlConnection();

            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";

            string query =
                    "SELECT temperatuur, tijdstip FROM weerdata WHERE plaats = @cityName";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cityName", cityName.ToString());
                MySqlDataReader Datareader = cmd.ExecuteReader();

                string Symbol = "";
                if (unit == "metric")
                {
                    Symbol = "°C";
                }
                else if (unit == "imperial")
                {
                    Symbol = "°F";
                }
                else
                {
                    Symbol = "Error Symbol";
                }

                chart1.Series["Temperatuur"].Points.Clear();
                chart1.ChartAreas["ChartArea1"].AxisY.Title = string.Format("Temp {0}", Symbol);

                while (Datareader.Read())
                {
                    chart1.Series["Temperatuur"].Points.AddXY(Datareader.GetString(1), Datareader.GetInt32(0));
                }

                Datareader.Close();
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Show error
                MessageBox.Show(ex.Message);
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
            // als je op X drukt sluit de applicatie maar hij blijft aan staan
            e.Cancel = true;
            Visible = false;
        }

        private void verversenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // verversen
            this.GetWeather(cityName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // als je een setting aanpast veranderd alles aan de hand hiervan
            this.cityName = inputPlaats.Text;
            this.interval = int.Parse(inputInterval.Text);
            this.GetWeather(cityName);
            this.GetForecast(cityName);
            this.tabControl1.SelectedIndex = 0;
            this.DBplaceholder();

            if (F.Checked == true)
            {
                unit = "imperial";
            }
            else
            {
                unit = "metric";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.GetWeather(cityName);
            this.DBplaceholder();
        }
    }
}
