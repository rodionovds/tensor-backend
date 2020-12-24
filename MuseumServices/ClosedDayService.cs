using System.Collections.Generic;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class ClosedDayService : IClosedDay
    {
        private readonly MuseumContext _context;

        public ClosedDayService(MuseumContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Doll> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Doll Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Doll newItem)
        {
            throw new System.NotImplementedException();
        }
    }
}