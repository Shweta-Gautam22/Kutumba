using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public class ServiceRestaurants:IRestaurants
    {

        private readonly IRestaurantRepository _restaurant;

        public ServiceRestaurants(IRestaurantRepository restaurant)
        {
            _restaurant = restaurant;
        }

        public async Task<List<Restaurant>> GetAllRestaurants()
        {
            return await _restaurant.GetAllRestaurants();
        }

        public async Task<List<Restaurant>> AddRestaurants(Restaurant I)
        {
            return await _restaurant.AddRestaurants(I);
        }

        public async Task<Restaurant> GetSingleRestaurant(int Id)
        {
            return await _restaurant.GetSingleRestaurant(Id);
        }

        public async Task<Restaurant> UpdateRestaurant(int Id, Restaurant Request)
        {
            return await _restaurant.UpdateRestaurant(Id, Request);
        }

        public async Task<List<Restaurant>> DeleteRestaurant(int Id)
        {
            return await _restaurant.DeleteRestaurant(Id);
        }
    }
}
