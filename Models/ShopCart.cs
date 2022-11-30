using Gosha.Data;
using Microsoft.EntityFrameworkCore;

namespace Gosha.Models
{
    public class ShopCart
    {
        private readonly AppDBcontext? AppDbContext;
        public ShopCart(AppDBcontext dBcontext) => this.AppDbContext = dBcontext;
        public string? ShopCartId { get; set; }
        public List<ShopCartItem>? listShopItems { get; set; }
        public static ShopCart? GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBcontext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        public void AddToCart(Car car)
        {
            AppDbContext.ShopCartItem.Add(new ShopCartItem
                {
                ShopCartId = ShopCartId,
                Car = car,
                Price = (uint)car.Price
            });

            AppDbContext.SaveChanges();
        }
        public List<ShopCartItem> GetItems() => AppDbContext.ShopCartItem.Where(x => x.ShopCartId == ShopCartId).Include(s => s.Car).ToList();

    }
}
