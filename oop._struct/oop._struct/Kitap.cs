using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._struct
{
    class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Tür { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime YayinTarihi { get; set; }
    }
    struct Book
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Tür { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime YayinTarihi { get; set; }
    }
}
