using System.Collections.Generic;
using MuseumData.Models;

namespace MuseumData
{
    public interface IDoll : IBase<Doll>
    {
        IEnumerable<Doll> GetWithLimit(int limit);
    }
}