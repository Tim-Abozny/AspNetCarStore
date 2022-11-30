using Gosha.Data;
using Gosha.Models;

namespace Gosha.Garbage
{
    public class DbInitializer
    {
        public static void Initial(AppDBcontext appDbContext)
        {
            if (!appDbContext.Category.Any())
                appDbContext.Category.AddRange(Categories.Select(c => c.Value));

            if (!appDbContext.Car.Any())
            {
                appDbContext.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Mask prank",
                        LongDescription = "This is a first electric car",
                        Image = "/img/tesla.jpg",
                        Price = 32000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Electric cars"]
                    },
                    new Car
                    {
                        Name = "Ford Mustang",
                        ShortDescription = "Police classic",
                        LongDescription = "Car for bad boys on street roads",
                        Image = "/img/ford.jpg",
                        Price = 27000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["ICE cars"]
                    },
                    new Car
                    {
                        Name = "Nissan Lief",
                        ShortDescription = "Ubogestvo ot prirodi",
                        LongDescription = "The fastest car in this World",
                        Image = "/img/nissan.jpg",
                        Price = 15000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Electric cars"]
                    },
                    new Car
                    {
                        Name = "BMW M5",
                        ShortDescription = "Germany trash",
                        LongDescription = "This car will broke every day :)",
                        Image = "/img/bmw.jpg",
                        Price = 60000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["ICE cars"]
                    },
                    new Car
                    {
                        Name = "Audi RS Q8",
                        ShortDescription = "BUY ME",
                        LongDescription = "The most powerfull and comfortable car",
                        Image = "/img/audi.jpg",
                        Price = 140000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["ICE cars"]
                    }
                    );
            }
            appDbContext.SaveChanges();
        }

        private static Dictionary<string, Category>? category;
        private static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Electric cars", Description = "Cars evolution" },
                        new Category { CategoryName = "ICE cars", Description = "Internal combustion engine" }
                    };
                    
                    category = new Dictionary<string, Category>();
                    foreach (Category l in list)
                    {
                        category.Add(l.CategoryName, l);
                    }
                }

                return category;
            }
        }
    }
}
