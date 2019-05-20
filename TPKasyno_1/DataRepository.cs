using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPKasyno_1
{
    class DataRepository : IRepositoryGracz, IRepositoryKatalog, IRepositoryStan, IRepositoryZdarzenie
    {

        private DataContext kontekst;


        
        public DataRepository(IWypelnianieStalymi wypelnianie)
        {
            kontekst = new DataContext();

            kontekst.WypelnijOsoby(wypelnianie.PobierzGraczy());
            kontekst.WypelnijSlownik(wypelnianie.PobierzGry());
            kontekst.WypelnijStany(wypelnianie.PobierzStan());
            kontekst.WypelnijZdarzenia(wypelnianie.PobierzZdarzenie());
        }

        public void AddGracz(Gracz gracz)
        {
            throw new NotImplementedException();
        }

        public void AddKatalog(Katalog katalog)
        {
            throw new NotImplementedException();
        }

        public void AddStan(OpisStanu stan)
        {
            throw new NotImplementedException();
        }

        public void AddZdarzenie(Zdarzenie zdarzenie)
        {
            throw new NotImplementedException();
        }

        public void DeleteGracz(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteKatalog(string Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteStan(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteZdarzenie(int Id)
        {
            throw new NotImplementedException();
        }

        public Gracz[] GetAllGracz()
        {
            return kontekst.Osoby.Select(osoba => osoba as Gracz).ToArray();
        }

        public Katalog[] GetAllKatalog()
        {
            return kontekst.Katalog.Select(katalog => katalog.Value).ToArray();
        }

        public OpisStanu[] GetAllStan()
        {
            return kontekst.OpisyStanow.ToArray();
        }

        public Zdarzenie[] GetAllZdarzenie()
        {
            return kontekst.Zdarzenia.ToArray();
        }

        public Gracz GetGracz(int Id)
        {
            return kontekst.Osoby.FirstOrDefault(osoba => osoba.Id == Id) as Gracz;
        }

        public Katalog GetKatalog(string NazwaGry)
        {
            return kontekst.Katalog.FirstOrDefault(x => x.Key == NazwaGry).Value;
        }

        public OpisStanu GetStan(int Id)
        {
            return kontekst.OpisyStanow.FirstOrDefault(stan => stan.Id == Id);
        }

        public Zdarzenie GetZdarzenie(int Id)
        {
            return kontekst.Zdarzenia.FirstOrDefault(zdarzenie => zdarzenie.Id == Id);
        }

        public Gracz UpdateGracz(Gracz gracz)
        {
            throw new NotImplementedException();
        }

        public Katalog UpdateKatalog(Katalog katalog)
        {
            throw new NotImplementedException();
        }

        public OpisStanu UpdateStan(OpisStanu stan)
        {
            throw new NotImplementedException();
        }

        public Zdarzenie UpdateZdarzenie(Zdarzenie zdarzenie)
        {
            throw new NotImplementedException();
        }
    }
}
