using System;
using System.Collections.Generic;

namespace MuseumData
{
    public interface IBase<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);

        void Add(T newItem);
    }
}