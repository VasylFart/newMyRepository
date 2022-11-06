using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood;
using OdeToFood.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OdeToFood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
