using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Application.DTO
{
    public class RestaurantDto
    {
        public string RestaurantName { get; set; }
        public IFormFile? Image { get; set; }


    }
}
