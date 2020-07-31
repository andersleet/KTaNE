using System;
using System.Diagnostics;
using System.Windows;
using Caliburn.Micro;
using KTaNE.ViewModels;

namespace KTaNE
{
    public class Bootstrapper : BootstrapperBase
    {

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            //Debugger.Break();
        }
    }
}