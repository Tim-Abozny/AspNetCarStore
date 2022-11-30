using Gosha.Data;
using Gosha.Interfaces;
using Gosha.Models;
using Microsoft.EntityFrameworkCore;

namespace Gosha.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDBcontext? AppDbContext;
        public CarRepository(AppDBcontext dBcontext) => this.AppDbContext = dBcontext;
        public IEnumerable<Car> Cars => AppDbContext.Car.Include(c => c.Category);

        public IEnumerable<Car> FavorCars => AppDbContext.Car.Where(f => (bool)f.IsFavourite).Include(c => c.Category);

        public Car GetCar(int id) => AppDbContext.Car.FirstOrDefault(c => c.Id == id);
    }
}
