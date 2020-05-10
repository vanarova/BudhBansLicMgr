using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Helper;
using Core.ViewModel;
using Gecko;
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
            I_VM_Alert vm_Alert = new VM_Alert();
            //register instances
            LightInjectHelper li = new LightInjectHelper();
            li.RegisterInstance<I_VM_Alert>(vm_Alert);
            ServiceContainer service = li.service;
            Xpcom.Initialize("Firefox");
            //Execute Test stub
            //UnitTests.Stubs.Run(service);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new test());
            Application.Run(new MdiMain(service));
        }
    }
}
