﻿using Caliburn.Micro;
using SerialCommunication.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SerialCommunication.UI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();

            LogManager.GetLog = type => new DebugLog(type);
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            await DisplayRootViewForAsync(typeof(ShellViewModel));  
        }

    }
}
