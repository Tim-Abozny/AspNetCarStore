using Gosha.Interfaces;
using Gosha.Models;
using Gosha.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace Gosha.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _cars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(ICars cars, ICarsCategory carsCategory)
        {
            this._cars = cars;
            this._carsCategory = carsCategory;
        }
        [Route("Cars/")]
        [Route("Cars/{category}")]
        public IActionResult Index(string category)
        {
            IEnumerable<Car> cars;
            if (string.IsNullOrEmpty(category))
            {
                cars = _cars.Cars.OrderBy(c => c.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _cars.Cars.Where(c => c.Category.CategoryName.Equals("Electric cars")).OrderBy(c => c.Id);
                }
                else
                {
                    cars = _cars.Cars.Where(c => c.Category.CategoryName.Equals("ICE cars")).OrderBy(c => c.Id);
                }
            }

            return View(new CarViewComponent { cars = cars, CurrentCategory = category });
        }
    }
}
