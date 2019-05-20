using System;
using System.Collections.Generic;
using System.Text;

namespace TPKasyno_1
{
    public class Zdarzenie
    {
        public int Id { get; set; }
        public Osoba Gracz{ get; set; }
        public Katalog Gra { get; set; }
        public int NumerStolu { get; set; }
    }
}
