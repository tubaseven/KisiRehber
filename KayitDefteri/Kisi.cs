using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayitDefteri
{
    public class Kisi
    {
        public Kisi(string Ad,string Soyad,string Telefon,string Adres)//constructor
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Telefon = Telefon;
            this.Adres = Adres; 
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }

}

