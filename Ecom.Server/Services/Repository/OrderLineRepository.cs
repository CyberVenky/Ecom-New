using Ecom.Server.Data;
using Ecom.Server.Models;
using Ecom.Server.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Server.Services.Repository
{
    public class OrderLineRepository(ApplicationDbContext context) : IOrderLine
    {
        private ApplicationDbContext _context = context;

        public int Count()
        {
            return _context.OrderLines.Count();
        }

        public void Delete(int id)
        {
            var orderline = _context.OrderLines.FirstOrDefault(c => c.Id == id);
            if (orderline != null)
            {
                _context.OrderLines.Remove(orderline);
            }
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _context.OrderLines;
        }

        public OrderLine GetOrderLine(int id)
        {
            var orderline = _context.OrderLines.FirstOrDefault(c => c.Id == id);
            if (orderline != null)
            {
                return orderline;
            }
            return null;
        }

        public void Insert(OrderLine orderline)
        {
            _context.OrderLines.Add(orderline);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(OrderLine OrderLine)
        {
            _context.OrderLines.Update(OrderLine);
        }
    }
}
