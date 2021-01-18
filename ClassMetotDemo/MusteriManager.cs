using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " Kaydınız alınmıştır.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " Kaydınız Silinmiştir.");
        }

        public void MusteriListele(Musteri[] musteriler )
        {
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
