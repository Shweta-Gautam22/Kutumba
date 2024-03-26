using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KutumbaBhoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrders : ControllerBase
    {
        //injecting a Services
        private readonly IOrder _services;

        public ServiceOrders(IOrder services)
        {
            _services = services;
        }

        //GET:api
        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            var result = await _services.GetAllOrders();
            return Ok(result);
        }

        //Adding a order
        [HttpPost]
        public async Task<ActionResult<List<Order>>> AddOrders(Order I)
        {
            var result = await _services.AddOrders(I);
            return Ok(result);
        }

        //Reading a single order
        [HttpGet("{Id}")]
        public async Task<ActionResult<Order>> GetSingleOrder(int Id)
        {
            var result = await _services.GetSingleOrder(Id);
            if (result is null)
                return NotFound("Item not found");

            return Ok(result);
        }

        //Updating a order
        [HttpPut("{Id}")]
        public async Task<ActionResult<Order>?> UpdateOrder(int Id, Order Request)
        {
            var result = await _services.UpdateOrder(Id, Request);
            if (result is null)
                return NotFound("Orders not found");

            return Ok(result);
        }

        //Deleting a order
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Order>>?> DeleteOrder(int Id)
        {
            var result = await _services.DeleteOrder(Id);
            if (result is null)
                return null;

            return Ok(result);
        }
    }
}
