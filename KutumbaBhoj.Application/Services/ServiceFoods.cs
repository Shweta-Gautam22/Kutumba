using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public class ServiceFoods:IFoods
    {
        private readonly IFoodRepository _foods;

        public ServiceFoods(IFoodRepository foods)
        {
            _foods = foods;
        }

        public async Task<List<Food>> GetAllFoods()
        {
            return await _foods.GetAllFoods();
        }

        public async Task<List<Food>> AddFoods(Food I)
        {
            return await _foods.AddFoods(I);
        }

        public async Task<Food> GetSingleFood(int Id)
        {
            return await _foods.GetSingleFood(Id);
        }

        public async Task<Food> UpdateFood(int Id, Food Request)
        {
            return await _foods.UpdateFood(Id, Request);
        }

        public async Task<List<Food>> DeleteFood(int Id)
        {
            return await _foods.DeleteFood(Id);
        }



    }
}
