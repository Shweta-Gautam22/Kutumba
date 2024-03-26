using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;
using KutumbaBhoj.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;

namespace KutumbaBhoj.Infrastructure.Repository
{
    public class FoodRepository:IFoodRepository
    {
        
        private readonly DataContext _dbContext;

        public FoodRepository(DataContext DbContext)
        {
            _dbContext = DbContext;
        }

        public async Task<List<Food>> GetAllFoods()
        {
            return await _dbContext.Foods.ToListAsync();
        }

        public async Task<List<Food>> AddFoods(Food i)
        {
            _dbContext.Foods.Add(i);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Foods.ToListAsync();
        }

        public async Task<Food> GetSingleFood(int id)
        {
            return await _dbContext.Foods.FindAsync(id);
        }

        public async Task<Food> UpdateFood(int id, Food request)
        {
            Food existingFood = await _dbContext.Foods.FindAsync(id);
            if (existingFood != null)
            {
                existingFood.FoodTitle = request.FoodTitle;
                existingFood.FoodPrice = request.FoodPrice;
                existingFood.foodRating = request.foodRating;
                await _dbContext.SaveChangesAsync();
            }
            return existingFood;
        }

        public async Task<List<Food>> DeleteFood(int id)
        {
            Food existingFood = await _dbContext.Foods.FindAsync(id);
            if (existingFood != null)
            {
                _dbContext.Foods.Remove(existingFood);
                await _dbContext.SaveChangesAsync();
            }
            return await _dbContext.Foods.ToListAsync();
        }


    }
}
