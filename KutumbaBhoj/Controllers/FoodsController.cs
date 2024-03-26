using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutumbaBhoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceFoods : ControllerBase
    {
        private readonly IFoods _services;

        public ServiceFoods(IFoods services)
        {
            _services = services;
        }

        //GET:api
        [HttpGet]
        public async Task<ActionResult<List<Food>>> GetAllFoods()
        {
            var result = await _services.GetAllFoods();
            return Ok(result);
        }

        //Adding a dishes
        [HttpPost]
        public async Task<ActionResult<List<Food>>> AddFoods(Food I)
        {
            var result = await _services.AddFoods(I);
            return Ok(result);
        }

        //Reading a single food
        [HttpGet("{Id}")]
        public async Task<ActionResult<Food>> GetSingleFood(int Id)
        {
            var result = await _services.GetSingleFood(Id);
            if (result is null)
                return NotFound("Item not found");

            return Ok(result);
        }

        //Updating a food
        [HttpPut("{Id}")]
        public async Task<ActionResult<Food>?> UpdateFood(int Id, Food Request)
        {
            var result = await _services.UpdateFood(Id, Request);
            if (result is null)
                return NotFound("Dishes not found");

            return Ok(result);
        }


        //Deleting a food
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Food>>?> DeleteDish(int Id)
        {
            var result = await _services.DeleteFood(Id);
            if (result is null)
                return null;

            return Ok(result);
        }

    }
}
