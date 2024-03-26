using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace KutumbaBhoj.Application.DTO
{
    public class DishesDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IFormFile? Image { get; set; }

    }
}
