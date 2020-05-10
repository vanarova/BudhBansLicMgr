using Gecko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWebBrowserApp
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
            Xpcom.Initialize("Firefox");
            //var geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            //Form f = new Form();
            //f.Controls.Add(geckoWebBrowser);
            //geckoWebBrowser.Navigate("www.google.com");
            Application.Run(new Form1());
        }
    }
}
