using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant); //doaj nową restawracje
        Restaurant Delete(int id); // Usuwa restawracje
        int GetCountOfRestaurants();
        int Commit();
    }
}
