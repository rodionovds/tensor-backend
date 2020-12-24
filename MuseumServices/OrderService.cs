using System.Collections.Generic;
using System.Linq;
using MuseumData;
using MuseumData.Models;
using MuseumData.Models.Enum;

namespace MuseumServices
{
    public class OrderService : IOrder
    {
        private readonly MuseumContext _context;

        public OrderService(MuseumContext context)
        {
            _context = context;
        }


        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order Get(int id)
        {
            return _context.Orders.FirstOrDefault(h => h.Id == id);
        }

        public void Add(Order newItem)
        {
            _context.Orders.Add(newItem);
            _context.SaveChanges();
        }

        public void ChangeStatus(int orderId, OrderStatus status)
        {
            var order = Get(orderId);
            _context.Update(order);
            order.Status = status;
            _context.SaveChanges();
        }
    }
}