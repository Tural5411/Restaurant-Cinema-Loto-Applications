using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp
{
    public class Stol
    {
        public int Id { get; set; }
        public string StolKodu { get; set; }
        public string StolAdi { get; set; }
        public List<MehsulHereket> Hereketleri { get; set; }

    }
    public class Mehsul
    {
        public int Id { get; set; }
        public string MehsulKodu { get; set; }
        public string MehsulAdi { get; set; }
        public string Vahidi { get; set; }
        public decimal Qiymet { get; set; }
        public List<MehsulHereket> MehsulHereketleri { get; set; }
    }

    public class MehsulHereket
    {
        public string StolKodu { get; set; }
        public string MehsulKodu { get; set; }
        public string MehsulAdi { get; set; }
        public string Vahidi { get; set; }
        public decimal Qiymet { get; set; }
        public decimal Miqdar { get; set; }
    }
}
