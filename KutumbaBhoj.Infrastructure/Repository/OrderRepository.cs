using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;
using KutumbaBhoj.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Infrastructure.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _dbContext;

        public OrderRepository(DataContext DbContext)
        {
            _dbContext = DbContext;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            return await _dbContext.Orders.ToListAsync();
        }

        public async Task<List<Order>> AddOrders(Order i)
        {
            _dbContext.Orders.Add(i);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Orders.ToListAsync();
        }
        public async Task<Order> GetSingleOrder(int id)
        {
            return await _dbContext.Orders.FindAsync(id);
        }
        public async Task<Order> UpdateOrder(int id, Order request)
        {
            Order existingOrder = await _dbContext.Orders.FindAsync(id);
            if (existingOrder != null)
            {
                existingOrder.OrderQty = request.OrderQty;
                existingOrder.Price = request.Price;
                existingOrder.OrderDate = request.OrderDate;

                await _dbContext.SaveChangesAsync();
            }
            return existingOrder;
        }
        public async Task<List<Order>> DeleteOrder(int id)
        {
            Order existingItem = await _dbContext.Orders.FindAsync(id);
            if (existingItem != null)
            {
                _dbContext.Orders.Remove(existingItem);
                await _dbContext.SaveChangesAsync();
            }
            return await _dbContext.Orders.ToListAsync();
        }

    }
}
