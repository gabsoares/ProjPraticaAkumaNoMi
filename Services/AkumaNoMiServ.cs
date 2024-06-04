using Models;
using Repositories;

namespace Services
{
    public class AkumaNoMiServ
    {
        private AkumaNoMiRep _akumaNoMiRep;

        public AkumaNoMiServ()
        {
            _akumaNoMiRep = new();
        }

        public int Insert(AkumaNoMi a)
        {
            return _akumaNoMiRep.InsertAkumaNoMi(a);
        }
    }
}
