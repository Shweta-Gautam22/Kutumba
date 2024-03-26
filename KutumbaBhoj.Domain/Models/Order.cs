using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Domain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderQty { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public bool DeliveryStatus { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Dish")]
        public int DishId { get; set; }

    }
}
