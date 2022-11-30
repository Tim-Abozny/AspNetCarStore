using Gosha.Interfaces;
using Gosha.Models;

namespace Gosha.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get =>
new List<Car> {
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Mask prank",
                        LongDescription = "This is a first electric car",
                        Image = "/img/tesla.jpg",
                        Price = 32000,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.Categories.First()
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
                        Category = _carsCategory.Categories.Last()
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
                        Category = _carsCategory.Categories.First()
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
                        Category = _carsCategory.Categories.Last()
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
                        Category = _carsCategory.Categories.Last()
                    }
};
        }
        public IEnumerable<Car> FavorCars { get; set; }

        public Car GetCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
