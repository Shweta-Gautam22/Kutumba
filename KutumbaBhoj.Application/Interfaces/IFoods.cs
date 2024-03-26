using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{

    public interface IFoods
    {
        Task<List<Food>> GetAllFoods();

        Task<List<Food>> AddFoods(Food i);

        Task<Food> GetSingleFood(int id);

        Task<Food> UpdateFood(int id, Food Request);

        Task<List<Food>> DeleteFood(int id);
    }
}