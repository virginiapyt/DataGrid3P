using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid3P
{
    public class Product
    { public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int  LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }
        public bool Dostepny { get; set; }

        public Uri Zdjecie { get; set; }

        public Product(string symbol, string nazwa, int liczbaSztuk, 
            string magazyn, Uri zdjecie)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            LiczbaSztuk = liczbaSztuk;
            Magazyn = magazyn;
            Dostepny = true;
            Zdjecie = zdjecie;
        }
    }
}
