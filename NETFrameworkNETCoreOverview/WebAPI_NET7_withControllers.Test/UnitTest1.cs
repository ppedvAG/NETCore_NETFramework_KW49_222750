using Microsoft.EntityFrameworkCore;
using WebAPI_NET7_withControllers.Controllers;
using WebAPI_NET7_withControllers.Data;
using WebAPI_NET7_withControllers.Models;

namespace WebAPI_NET7_withControllers.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=WebAPI_NET7_withControllers.Data;Trusted_Connection=True;MultipleActiveResultSets=true";

            using WebAPI_NET7_withControllersContext dbContext = new WebAPI_NET7_withControllersContext();

            MoviesController movieController = new MoviesController(dbContext);

            var allMovies =  movieController.GetMovies();

            Assert.NotEqual(allMovies.Result.Value.Count(), 0);
        }
    }
}