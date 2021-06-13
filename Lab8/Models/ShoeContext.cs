using Microsoft.EntityFrameworkCore;

namespace Lab8.Models
{
    public class ShoeContext : DbContext
    {
        public DbSet<Shoe> Shoes { get; set; }

        public ShoeContext(DbContextOptions<ShoeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}