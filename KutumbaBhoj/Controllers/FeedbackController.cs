using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutumbaBhoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceFeedback : ControllerBase
    {
        //injecting a Services
        private readonly IFeedback _services;

        public ServiceFeedback(IFeedback services)
        {
            _services = services;
        }

        //GET:api
        [HttpGet]
        public async Task<ActionResult<List<Feedback>>> GetAllFeedbacks()
        {
            var result = await _services.GetAllFeedbacks();
            return Ok(result);
        }

        //Adding a Feedback
        [HttpPost]
        public async Task<ActionResult<List<Feedback>>> AddFeedbacks(Feedback I)
        {
            var result = await _services.AddFeedbacks(I);
            return Ok(result);
        }

        //Reading a single feedback
        [HttpGet("{Id}")]
        public async Task<ActionResult<Feedback>> GetSingleFeedback(int Id)
        {
            var result = await _services.GetSingleFeedback(Id);
            if (result is null)
                return NotFound("Item not found");

            return Ok(result);
        }

        //Updating a Feedback
        [HttpPut("{Id}")]
        public async Task<ActionResult<Feedback>?> UpdateFeedback(int Id, Feedback Request)
        {
            var result = await _services.UpdateFeedback(Id, Request);
            if (result is null)
                return NotFound("Feedback not found");

            return Ok(result);
        }

        //Deleting a dish
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Feedback>>?> DeleteFeedback(int Id)
        {
            var result = await _services.DeleteFeedback(Id);
            if (result is null)
                return null;

            return Ok(result);
        }
    }
}
