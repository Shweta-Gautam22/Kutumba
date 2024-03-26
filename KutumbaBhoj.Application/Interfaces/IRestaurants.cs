using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public interface IRestaurants
    {
        Task<List<Restaurant>> GetAllRestaurants();

        Task<List<Restaurant>> AddRestaurants(Restaurant i);

        Task<Restaurant> GetSingleRestaurant(int id);

        Task<Restaurant> UpdateRestaurant(int id, Restaurant Request);

        Task<List<Restaurant>> DeleteRestaurant(int id);
    }
}
