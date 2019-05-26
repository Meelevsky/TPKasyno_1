using System;

namespace TPKasyno_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dr = new DataRepository(new WypelnianieStalymi());
            var a = dr.GetKatalog("kasyno");

            var dr2 = new DataRepository(new WypelnianieStalymiJSON());
            Console.WriteLine("Hello World!");
        }
    }
}
