using KutumbaBhoj.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace KutumbaBhoj.Infrastructure.DbContext
{


    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Ignore(f => f.Name);

            // Other configurations for your entities...

            base.OnModelCreating(modelBuilder);
        }



    }
}








