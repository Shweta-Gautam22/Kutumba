using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Domain.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodTitle { get; set; }
        public decimal FoodPrice { get; set; }
        public int foodRating { get; set; }
        public enum FoodRating
        {
            Poor = 1,
            Fair,
            Good,
            VeryGood,
            Excellent
        }
        public string FoodFavouriteStatus { get; set; }
        public object Name { get; set; }
    }
}
