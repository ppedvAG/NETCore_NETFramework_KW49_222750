using MauiAppNet7.Services;
using Microsoft.Extensions.Logging;

namespace MauiAppNet7
{
    public static class MauiProgram
    {
        //MAUI kann einen IOC Container verwenden 
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            //builder.Services.AddSingleton<ITimeService, TimeService>();
            builder.Services.AddSingleton<Car>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            

            return builder.Build();
        }
    }


    public class Car
    {
        public string Name { get; set; } = "VW";
    }
}