using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_NET7_withControllers.Models;

namespace WebAPI_NET7_withControllers.Data
{
    public class WebAPI_NET7_withControllersContext : DbContext
    {
        public WebAPI_NET7_withControllersContext()
        {

        }


        public WebAPI_NET7_withControllersContext(DbContextOptions<WebAPI_NET7_withControllersContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_NET7_withControllers.Models.Movies> Movies { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebAPI_NET7_withControllers.Data;Trusted_Connection=True;");
        }

    }
}
