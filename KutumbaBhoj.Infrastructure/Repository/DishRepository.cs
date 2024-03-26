using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Infrastructure.DbContext;
using KutumbaBhoj.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace KutumbaBhoj.Infrastructure.Repository
{
    public class DishRepository:IDishRepository
    {
        private readonly DataContext _dbContext;

        public DishRepository(DataContext DbContext)
        {
            _dbContext = DbContext;
        }

        public async Task<List<Dish>> GetAllDishes()
        {
            return await _dbContext.Dishes.ToListAsync();
        }

        public async Task<List<Dish>> AddDishes(Dish i)
        {
            _dbContext.Dishes.Add(i);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Dishes.ToListAsync();
        }

        public async Task<Dish> GetSingleDish(int id)
        {
            return await _dbContext.Dishes.FindAsync(id);
        }

        public async Task<Dish> UpdateDish(int id, Dish request)
        {
            Dish existingDish = await _dbContext.Dishes.FindAsync(id);
            if (existingDish != null)
            {
                existingDish.Description = request.Description;
                existingDish.Price = request.Price;
                await _dbContext.SaveChangesAsync();
            }
            return existingDish;
        }

        public async Task<List<Dish>> DeleteDish(int id)
        {
            Dish existingItem = await _dbContext.Dishes.FindAsync(id);
            if (existingItem != null)
            {
                _dbContext.Dishes.Remove(existingItem);
                await _dbContext.SaveChangesAsync();
            }
            return await _dbContext.Dishes.ToListAsync();
        }


    }
}
