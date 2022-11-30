using Gosha.Interfaces;
using Gosha.Models;
using Gosha.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace Gosha.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly ICars? _carRepository;
        private readonly ShopCart? _shopCart;
        public ShopCartController(ICars carRepository, ShopCart shopCart)
        {
            _carRepository = carRepository;
            _shopCart = shopCart;
        }
        public IActionResult Index()
        {
            var items = _shopCart.GetItems();
            _shopCart.listShopItems = items;
            var obj = new ShopCartViewComponent
            {
                shopCart = _shopCart
            };

            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRepository.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
                _shopCart.AddToCart(item);
            
            return RedirectToAction("Index");
        }
    }
}
