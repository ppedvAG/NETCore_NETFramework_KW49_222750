
using Microsoft.EntityFrameworkCore;
using WebAPI_CodeFirstRevereseSample.Data;

namespace WebAPI_CodeFirstRevereseSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //Einbindung von EF Core in IOC Container 
            builder.Services.AddDbContext<WebApiNet7WithControllersDataContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebAPI_NET7_withControllersContext") ?? throw new InvalidOperationException("Connection string 'WebAPI_NET7_withControllersContext' not found.")));



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


            app.MapControllers();

            app.Run();
        }
    }
}