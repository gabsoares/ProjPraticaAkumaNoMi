using Models;
using Services;

namespace Controllers
{
    public class UserCont
    {
        private UserServ _userService;
        private AkumaNoMiServ _akumaNoMiServ;

        public UserCont()
        {
            _userService = new();
            _akumaNoMiServ = new();
        }

        public bool Insert(User user)
        {
            user.AkumaNoMi.Id = _akumaNoMiServ.Insert(user.AkumaNoMi);
            return _userService.Insert(user);
        }
    }
}
