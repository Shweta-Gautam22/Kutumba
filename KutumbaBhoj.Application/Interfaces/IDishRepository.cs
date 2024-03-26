﻿using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Interfaces
{
    public interface IDishRepository
    {
        Task<List<Dish>> GetAllDishes();

        Task<List<Dish>> AddDishes(Dish i);

        Task<Dish> GetSingleDish(int id);

        Task<Dish> UpdateDish(int id, Dish Request);

        Task<List<Dish>> DeleteDish(int id);

    }
}
