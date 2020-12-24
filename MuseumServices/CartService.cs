using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class CartService : ICart
    {
        private readonly MuseumContext _context;

        public CartService(MuseumContext context)
        {
            _context = context;
        }

        public IEnumerable<Cart> GetByOrderId(int id)
        {
            return _context.Carts.Where(h => h.OrderId == id);
        }

        public void Add(Cart item)
        {
            _context.Carts.Add(item);
            _context.SaveChanges();
        }
    }
}