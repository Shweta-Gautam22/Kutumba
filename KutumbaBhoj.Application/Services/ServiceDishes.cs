using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services

{
    public class ServiceDishes: IDishes
    {
        private readonly IDishRepository _dishes;

        public ServiceDishes(IDishRepository dishes)
        {
            _dishes = dishes;
        }

        public async Task<List<Dish>> GetAllDishes()
        {
            return await _dishes.GetAllDishes();
        }

        public async Task<List<Dish>> AddDishes(Dish I)
        {
            return await _dishes.AddDishes(I);
        }

        public async Task<Dish> GetSingleDish(int Id)
        {
            return await _dishes.GetSingleDish(Id);
        }

        public async Task<Dish> UpdateDish(int Id, Dish Request)
        {
            return await _dishes.UpdateDish(Id, Request);
        }

        public async Task<List<Dish>> DeleteDish(int Id)
        {
            return await _dishes.DeleteDish(Id);
        }



    }
}
