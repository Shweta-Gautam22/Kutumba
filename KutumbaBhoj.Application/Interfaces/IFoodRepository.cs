using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Interfaces
{
    public interface IFoodRepository
    {
        Task<List<Food>> GetAllFoods();

        Task<List<Food>> AddFoods(Food i);

        Task<Food> GetSingleFood(int id);

        Task<Food> UpdateFood(int id, Food Request);

        Task<List<Food>> DeleteFood(int id);

    }
}
