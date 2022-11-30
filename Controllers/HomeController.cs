using Gosha.Interfaces;
using Gosha.Models;
using Gosha.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gosha.Controllers
{
    public class HomeController : Controller
    {
        private ICars? _allCars;
        public HomeController(ICars cars)
        {
            _allCars = cars;
        }
        public IActionResult Index() => View(new HomeViewComponent { favCars = _allCars.FavorCars });

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}