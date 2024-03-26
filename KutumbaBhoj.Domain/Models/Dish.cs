using System.ComponentModel.DataAnnotations;


namespace KutumbaBhoj.Domain.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public struct Rating
        {
            public int Lower { get; set; }
            public int Upper { get; set; }
            public int FinalRating { get; set; }
        }

    }
}
