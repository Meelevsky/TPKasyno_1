using System;
using System.Collections.Generic;
using System.Text;

namespace TPKasyno_1
{
    class DataService
    {
        IEnumerable<Katalog> WszystkiePozycjeKatalogu;
        IEnumerable<Zdarzenie> ZdarzeniaDlaElementuWykazu;
        IEnumerable<Zdarzenie> ZdarzeniaPomiedzyDatami;
        Zdarzenie DodajZdarzenie;
        IEnumerable<Katalog> WyswietlKatalog;
        IEnumerable<Zdarzenie> WyswietlPowiazaneZdarzenia;

    }
}
