using System.Linq;
using Lab8.Models;

namespace Lab8
{
    public static class SampleData
    {
        public static void Initialize(ShoeContext context)
        {
            if (!context.Shoes.Any())
            {
                context.Shoes.AddRange(
                    new Shoe
                    {
                        Name = "Slip-On",
                        Brand = "Van",
                        Price = 7000
                    },
                    new Shoe
                    {
                        Name = "Trabis Skott",
                        Brand = "Nikle",
                        Price = 12000
                    },
                    new Shoe
                    {
                        Name = "Retro Low Door",
                        Brand = "Fire Jordans",
                        Price = 9000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
