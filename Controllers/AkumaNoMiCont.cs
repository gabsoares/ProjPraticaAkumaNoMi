using Models;
using Services;

namespace Controllers
{
    public class AkumaNoMiCont
    {
        private AkumaNoMiServ _akumaNoMiService;

        public AkumaNoMiCont()
        {
            _akumaNoMiService = new();
        }

        public int Insert(AkumaNoMi a)
        {
            return _akumaNoMiService.Insert(a);
        }
    }
}
