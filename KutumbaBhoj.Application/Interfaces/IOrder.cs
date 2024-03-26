using KutumbaBhoj.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Application.Services
{
    public interface IOrder
    {
        Task<List<Order>> GetAllOrders();

        Task<List<Order>> AddOrders(Order i);

        Task<Order> GetSingleOrder(int id);

        Task<Order> UpdateOrder(int id, Order Request);

        Task<List<Order>> DeleteOrder(int id);
    }
}
