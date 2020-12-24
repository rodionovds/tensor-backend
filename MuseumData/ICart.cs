using System.Collections.Generic;
using MuseumData.Models;

namespace MuseumData
{
    public interface ICart
    {
        IEnumerable<Cart> GetByOrderId(int id);

        void Add(Cart item);
    }
}