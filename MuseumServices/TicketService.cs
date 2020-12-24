using System.Collections.Generic;
using System.Linq;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class TicketService : ITicket
    {
        private readonly MuseumContext _context;

        public TicketService(MuseumContext context)
        {
            _context = context;
        }
        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets.ToList();
        }

        public Ticket Get(int id)
        {
            return _context.Tickets.FirstOrDefault(h => h.Id == id);
        }

        public void Add(Ticket newItem)
        {
            _context.Tickets.Add(newItem);
            _context.SaveChanges();
        }
    }
}