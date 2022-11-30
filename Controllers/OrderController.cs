using Gosha.Interfaces;
using Gosha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gosha.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders? orders;
        private readonly ShopCart? shopCart;
        public OrderController(IOrders orders, ShopCart shopCart)
        {
            this.orders = orders;
            this.shopCart = shopCart;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Order order)
        {
            shopCart.listShopItems = shopCart.GetItems();
            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "You have nothing to pay");
            }
            if (ModelState.IsValid)
            {
                orders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "The order was processed successfully";
            return View();
        }
    }
}
