using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriAd = "Rukiye";
            Musteri1.MusteriSoyad = "YILMAZ";
            Musteri1.Yas = 29;
            Musteri1.Id = "01";

            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriAd = "Tuğba";
            Musteri2.MusteriSoyad = "YILMAZ";
            Musteri2.Yas = 30;
            Musteri2.Id = "02";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(Musteri1);
            musteriManager.MusteriEkle(Musteri2);

            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2 };

            foreach (var benimmusteri in musteriler)
            {
                Console.WriteLine(benimmusteri.Id);
                Console.WriteLine(benimmusteri.MusteriAd);
                Console.WriteLine(benimmusteri.MusteriSoyad);
                Console.WriteLine(benimmusteri.Yas);
            }
        }
    }
}
