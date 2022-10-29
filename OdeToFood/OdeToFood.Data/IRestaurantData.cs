using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetResturantsByName(string name);
        Restaurant GetByID(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        int Commit();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Skott`s Pizza", Lokation = "Maryland", Cuisine = Restaurant.CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Vasyl`s Lazania", Lokation = "Berszad", Cuisine = Restaurant.CuisineType.Ukraine },
                new Restaurant { Id = 3, Name = "Przemek`s Burger", Lokation = "Olsztyn", Cuisine = Restaurant.CuisineType.Poland }
            };
        }

        public Restaurant GetByID(int id)
        {
            return _restaurants.SingleOrDefault(r => r.Id == id);
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = _restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Lokation = updatedRestaurant.Lokation;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<Restaurant> GetResturantsByName(string name = null)
        {
            return from r in _restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith (name)
                   orderby r.Name
                   select r;
        }
    }
}
