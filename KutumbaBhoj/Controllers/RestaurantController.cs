using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KutumbaBhoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceRestaurants : ControllerBase
    {

        private readonly IRestaurants _services;

        public ServiceRestaurants(IRestaurants services)
        {
            _services = services;
        }

        //GET:api
        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetAllRestaurants()
        {
            var result = await _services.GetAllRestaurants();
            return Ok(result);
        }

        //Adding a restaurants
        [HttpPost]
        public async Task<ActionResult<List<Restaurant>>> AddRestaurants(Restaurant I)
        {
            var result = await _services.AddRestaurants(I);
            return Ok(result);
        }

        //Reading a single restaurant
        [HttpGet("{Id}")]
        public async Task<ActionResult<Restaurant>> GetSingleRestaurant(int Id)
        {
            var result = await _services.GetSingleRestaurant(Id);
            if (result is null)
                return NotFound("Item not found");

            return Ok(result);
        }

        //Updating a food
        [HttpPut("{Id}")]
        public async Task<ActionResult<Restaurant>?> UpdateRestaurant(int Id, Restaurant Request)
        {
            var result = await _services.UpdateRestaurant(Id, Request);
            if (result is null)
                return NotFound("Restaurants not found");

            return Ok(result);
        }

        //Deleting a restaurant
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Restaurant>>?> DeleteRestaurant(int Id)
        {
            var result = await _services.DeleteRestaurant(Id);
            if (result is null)
                return null;

            return Ok(result);
        }


    }
}
