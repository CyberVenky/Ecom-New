using Ecom.Server.Data;
using Ecom.Server.Models;
using Ecom.Server.Services.Infrastructure;

namespace Ecom.Server.Services.Repository
{
    public class OrderItemRepository(ApplicationDbContext context) : IOrder
    {
        private ApplicationDbContext _context = context;

        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(int id)
        {
            var Order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (Order != null)
            {
                _context.Orders.Remove(Order);
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                return order;
            }
            return null;
        }

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
        }
    }
}