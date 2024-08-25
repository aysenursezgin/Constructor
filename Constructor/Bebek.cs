using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

   
    public class Bebek
    {

        //Constructor metodu
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaaa");
        }
        //Bebek ası soyadı dönduren metot Alternatif constructor
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaaa");

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
