using WebApiContrib;
using WebApiContrib.Core;
using WebApiContrib.Core.Formatter.Csv;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPI_NET7_withControllers.Data;

namespace WebAPI_NET7_withControllers
{
    public class Program
    {
        
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Einbindung von EF Core in IOC Container 
            builder.Services.AddDbContext<WebAPI_NET7_withControllersContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebAPI_NET7_withControllersContext") ?? throw new InvalidOperationException("Connection string 'WebAPI_NET7_withControllersContext' not found.")));

            // Add services to the container.


            #region Auslesen von anderen Konfigurationsquellen
            //1.)
            //builder.Configuration.AddIniFile
            //Wenn ein Drittanbieter eine IniFile verwenden w�rde und wir m�ssen die Werte manuell auslesen 

            //2.)
            //Wenn ein Drittanbieter eine XMLFile verwendet 
            //builder.Configuration.AddXmlFile
            #endregion

            //hier wird ein IOC Container verwendet 
            builder.Services.AddControllers() //AddController besagt, dass wir in unserem ASP.NET Core-Projekt eine WebAPI verwendet 
                .AddXmlSerializerFormatters() //weitere Unterst�tzte Formate -> Formatters 
                .AddCsvSerializerFormatters();

          /*  builder.Services.AddControllersWithViews(); *///UI MVC
          /*  builder.Services.AddRazorPage();*/ //Razor Page

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers(); //MapControllers -> Ein Request wird zur richtigen HTTP-Methode (Ressource) navigiert
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}"); -> Navigation eines Requests f�r MVC 


            //app.MapRazorPages(); //Nagigation f�r Razor Pages
            app.Run();
        }
    }
}