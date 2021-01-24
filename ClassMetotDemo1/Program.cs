using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
             
           //string[] musteri = new string[] { };

           
            Musteri musteri1 = new Musteri(); //classtan değişken tanımlama
            musteri1.Id = 1;
            musteri1.Adi = "Derin";
            musteri1.Soyadi = "Artan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Burak";
            musteri2.Soyadi = "Doğru";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Derya";
            musteri3.Soyadi = "Taşkazan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("...........................");
            }

            Console.WriteLine("-----------------Metotlar------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri3);

        }
    }
}
