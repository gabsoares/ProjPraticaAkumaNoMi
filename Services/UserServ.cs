
using Models;
using Repositories;

namespace Services
{
    public class UserServ
    {
        private UserRep _userRep;

        public UserServ()
        {
            _userRep = new();
        }

        public bool Insert(User u)
        {
            return _userRep.InsertUser(u);
        }
    }
}
