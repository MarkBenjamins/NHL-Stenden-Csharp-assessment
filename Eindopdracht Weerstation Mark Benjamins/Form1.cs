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

namespace Eindopdracht_Weerstation_Mark_Benjamins
{
    public partial class Form1 : Form
    {
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
        }

        public void startSplashScreen()
        {
            Application.Run(new SplashScreen());
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
    }
}
