﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TPKasyno_1
{
    public interface IWypelnianieStalymi
    {
        Gracz[] PobierzGraczy();
        Katalog[] PobierzGry();
        Zdarzenie[] PobierzZdarzenie();
        OpisStanu[] PobierzStan();
    }
}
