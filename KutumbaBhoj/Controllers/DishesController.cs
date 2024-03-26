using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Domain.Models;
using Microsoft.AspNetCore.Mvc;


namespace KutumbaBhoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceDishes : ControllerBase
    {
        //injecting a Services
        private readonly IDishes _services;

        public ServiceDishes(IDishes services)
        {
            _services = services;
        }

        //GET:api
        [HttpGet]
        public async Task<ActionResult<List<Dish>>> GetAllDishes()
        {
            var result = await _services.GetAllDishes();
            return Ok(result);
        }

        //Adding a dishes
        [HttpPost]
        public async Task<ActionResult<List<Dish>>> AddDishes(Dish I)
        {
            var result = await _services.AddDishes(I);
            return Ok(result);
        }



        //Reading a single dish
        [HttpGet("{Id}")]
        public async Task<ActionResult<Dish>> GetSingleDish(int Id)
        {
            var result = await _services.GetSingleDish(Id);
            if (result is null)
                return NotFound("Item not found");

            return Ok(result);
        }

        //Updating a dish
        [HttpPut("{Id}")]
        public async Task<ActionResult<Dish>?> UpdateDish(int Id, Dish Request)
        {
            var result = await _services.UpdateDish(Id, Request);
            if (result is null)
                return NotFound("Dishes not found");

            return Ok(result);
        }

        //Deleting a dish
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Dish>>?> DeleteDish(int Id)
        {
            var result = await _services.DeleteDish(Id);
            if (result is null)
                return null;

            return Ok(result);
        }

    }

}




