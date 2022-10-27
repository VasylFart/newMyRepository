using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Core
{
    public partial class Restaurant
    {

        public int Id { get; set; } 
        public string Name { get; set; }
        public string Lokation { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
