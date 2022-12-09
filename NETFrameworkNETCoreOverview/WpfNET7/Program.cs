using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog.Events;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNET7
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {





            //Wir verwenden den Host von Microsoft.Extensions.Hosting;
            var host = Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.AddEventLog();
                    logging.SetMinimumLevel(LogLevel.Debug);
                })
                .ConfigureServices(services =>
                {
                    //und können den IOC Container verwenden (Singleton, Scoped, Transint)
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                })
                .Build(); //Nach Build kann der IOC-Container nicht weiter befüllt 



            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            //.WriteTo.Console()
            //.WriteTo.Seq("http://localhost:5341")
            .WriteTo.File("Log\\log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();


            //Erster Zugriff in IOC -> holen uns das App-Objet heraus
            var app = host.Services.GetService<App>();
            //Starten die Application 
            app.Run();
        }
    }
}
