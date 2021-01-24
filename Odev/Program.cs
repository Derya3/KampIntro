using System;

namespace Odev
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
            urun3.fiyat = 119.7;
            

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }
            foreach (var Urun in urunler)
                Console.WriteLine(urun.urunIsmi + " : " + urun.fiyat);
            {

            }
        }
        


    }
}
