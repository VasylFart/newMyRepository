using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood;
using OdeToFood.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var startup = new Startup(builder.Configuration);
        startup.ConfigureServices(builder.Services);

        var app = builder.Build();

        startup.Configure(app, builder.Environment);

        builder.Build();
    }
}
    