using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public class ServiceOrders:IOrder
    {
        private readonly IOrderRepository _orders;

        public ServiceOrders(IOrderRepository orders)
        {
            _orders = orders;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _orders.GetAllOrders();
        }

        public async Task<List<Order>> AddOrders(Order I)
        {
            return await _orders.AddOrders(I);
        }

        public async Task<Order> GetSingleOrder(int Id)
        {
            return await _orders.GetSingleOrder(Id);
        }

        public async Task<Order> UpdateOrder(int Id, Order Request)
        {
            return await _orders.UpdateOrder(Id, Request);
        }

        public async Task<List<Order>> DeleteOrder(int Id)
        {
            return await _orders.DeleteOrder(Id);
        }
    }
}
