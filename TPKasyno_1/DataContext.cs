using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TPKasyno_1
{
    class DataContext
    {
        public List<Osoba> Osoby;
        public Dictionary<string, Katalog> Katalog;
        public ObservableCollection<Zdarzenie> Zdarzenia;
        public List<OpisStanu> OpisyStanow;

        public void WypelnijOsoby(IEnumerable<Gracz> gracz)
        {
            this.Osoby = new List<Osoba>(gracz);
        }

        public void WypelnijSlownik(IEnumerable<Katalog> gry)
        {
            this.Katalog = gry.ToDictionary(key => key.NazwaGry, name => name);
        }

        public void WypelnijZdarzenia (IEnumerable<Zdarzenie> zdarzenie)
        {
            this.Zdarzenia = new ObservableCollection<Zdarzenie>(zdarzenie);
        }

        public void WypelnijStany(IEnumerable<OpisStanu> opisystanow)
        {
            this.OpisyStanow = new List<OpisStanu>(opisystanow);
        }
    }
}
