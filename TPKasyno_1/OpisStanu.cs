using System;
using System.Collections.Generic;
using System.Text;

namespace TPKasyno_1
{
    public class OpisStanu
    {
        public int Id { get; set; }
        public int IloscGier { get; set; }
        IEnumerable<int> NumerStolu { get; set; }
    }
}
