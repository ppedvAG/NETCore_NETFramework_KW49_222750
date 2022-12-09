using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfNET7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public class App : Application
    {
        private readonly MainWindow mainWindow;


        //Wir nochmals in den IOC Container (Konstruktor Injection) und wollen MainWindow anzeigen lassen
        public App(MainWindow mainWindow)
        {
            this.mainWindow= mainWindow;
        }

        protected override void OnStartup(StartupEventArgs e) 
        {
            mainWindow.Show();
            base.OnStartup(e);
        }

    }
}
