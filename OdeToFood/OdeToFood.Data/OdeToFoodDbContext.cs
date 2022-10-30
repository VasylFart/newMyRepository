using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            : base(options)
        {

        }

        // własciwości z danymi które chcę przechowywać w bazie danych
        public DbSet<Restaurant> Restaurants { get; set; }  //DbSet to typ który pozwala wyszukiwać,wstawiać, aktualizować i usuwać inf o resturacji 


    }
}
