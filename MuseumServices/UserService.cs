using System.Collections.Generic;
using System.Linq;
using MuseumData;
using MuseumData.Models;

namespace MuseumServices
{
    public class UserService : IUser
    {
        private readonly MuseumContext _context;

        public UserService(MuseumContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Get(int id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }

        public void Add(User newItem)
        {
            throw new System.NotImplementedException();
        }
    }
}