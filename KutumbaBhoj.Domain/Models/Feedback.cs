using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace KutumbaBhoj.Domain.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public DateTime Date {  get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Dish")]
        public int DishId { get; set; }
    }
}
