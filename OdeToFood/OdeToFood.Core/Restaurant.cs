using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Core
{
    public partial class Restaurant
    {

        public int Id { get; set; }

        [Required, StringLength(80)]             // Wymaga uzupenic pole oraz ustawia ,aksymalną ilość znaków
        public string Name { get; set; }

        [Required, StringLength(250)]
        public string Lokation { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
