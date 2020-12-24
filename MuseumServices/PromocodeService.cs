using System.Collections.Generic;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class PromocodeService : IPromocode
    
    {
        private readonly MuseumContext _context;

        public PromocodeService(MuseumContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Promocode> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Promocode Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Promocode newItem)
        {
            throw new System.NotImplementedException();
        }
    }
}