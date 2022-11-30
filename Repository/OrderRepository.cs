using Gosha.Data;
using Gosha.Interfaces;
using Gosha.Models;

namespace Gosha.Repository
{
    public class OrderRepository : IOrders
    {
        private readonly AppDBcontext? appDbContext;
        private readonly ShopCart? shopCart;
        public OrderRepository(AppDBcontext appDBcontext, ShopCart shopCart)
        {
            this.appDbContext = appDBcontext;
            this.shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContext.Order.Add(order);
            appDbContext.SaveChanges();
            var items = shopCart.listShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = item.Car.Id,
                    OrderId = order.Id,
                    Price = item.Car.Price
                };
                appDbContext.OrderDetail.Add(orderDetail);
            }
            appDbContext.SaveChanges();
        }
    }
}
