using System.Collections.Generic;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class PaymentService : IPayment
    {
        private readonly MuseumContext _context;

        public PaymentService(MuseumContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Payment> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Payment Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Payment newItem)
        {
            throw new System.NotImplementedException();
        }
    }
}