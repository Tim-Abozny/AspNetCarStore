using Gosha.Models;

namespace Gosha.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> FavorCars { get; }
        Car GetCar(int id);
    }
}
