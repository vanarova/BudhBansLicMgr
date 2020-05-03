using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Helper;
using LightInject;

namespace Titli
{
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            LightInjectHelper li = new LightInjectHelper();
            ServiceContainer service = li.service;

            //Execute Test stub
            //UnitTests.Stubs.Run(service);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new test());
            Application.Run(new MdiMain(service));
        }
    }
}
