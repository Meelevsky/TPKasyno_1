using System;
using System.Collections.Generic;
using System.Text;

namespace TPKasyno_1
{
    interface IRepositoryStan
    {
        void AddStan(OpisStanu stan);
        OpisStanu GetStan(int Id);
        OpisStanu[] GetAllStan();
        OpisStanu UpdateStan(OpisStanu stan);
        void DeleteStan(int Id);
    }
}
