using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.kategoriAdi = "Elbise";
            urun1.urunIsmi = "Kadife Elbise";
            urun1.fiyat = 215;

            Urun urun2 = new Urun();
            urun2.kategoriAdi = "Pantolon";
            urun2.urunIsmi = "Kadife Pantolon";
            urun2.fiyat = 151;

            Urun urun3 = new Urun();
            urun3.kategoriAdi = "Bluz";
            urun3.urunIsmi = "Crop Bluz";
            urun3.fiyat = 119;

            //Console.WriteLine(urun1.urunIsmi + " : " + urun1.fiyat);

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunIsmi + " : " + urunler[i].fiyat);
            }

            Console.WriteLine("For bitti");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunIsmi+ " : " + urun.fiyat);
            }

            Console.WriteLine("Foreach bitti");

            int m = 0;

            while (m<urunler.Length)
            {
                Console.WriteLine(urunler[m].urunIsmi+ " : " + urunler[m].fiyat);
                    
                    m++;
            }

                Console.WriteLine("While bitti");

                //Console.WriteLine("Hello World!");
            }
    }

    class Urun
    {
        public string kategoriAdi { get; set; }
        public string urunIsmi { get; set; }
        public int fiyat { get; set; }

    }
}
