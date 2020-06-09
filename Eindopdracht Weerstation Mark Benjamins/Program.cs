using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindopdracht_Weerstation_Mark_Benjamins
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

/*            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Text = "Weer applicatie C#";
            notifyIcon.ContextMenuStrip;

            BaseProgram baseProgram = new BaseProgram();
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Huidige temperatuur", null, baseProgram.Navigate("Huidige temperatuur"));*/
        }
    }

/*    class BaseProgram
    {
        internal EventHandler Navigate(string nav)
        {
            return ;
        }
    }*/
}
