using System.Collections.Generic;
using System.Linq;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class DollService : IDoll
    {
        private readonly MuseumContext _context;

        public DollService(MuseumContext context)
        {
            _context = context;
        }

        public IEnumerable<Doll> GetAll()
        {
            return _context.Dolls.ToList();
        }

        public IEnumerable<Doll> GetWithLimit(int limit)
        {
            return _context.Dolls.OrderByDescending(k => k.Id).Take(limit);
        }

        public Doll Get(int id)
        {
            return _context.Dolls.FirstOrDefault(h => h.Id == id);
        }

        public void Add(Doll newItem)
        {
            _context.Dolls.Add(newItem);
            _context.SaveChanges();
        }
    }
}