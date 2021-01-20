using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "rukiye", "tuğba","yasemin","nefise"}; //araylar oluşturduğun dizi içerisininin dışına yazılmaz. o yüzden fazla kullanılmaz
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];   
            //isimler[4] = "yeni";
            //Console.WriteLine(isimler[4]);   burada sadece referesan tip olduğu için yukarı silindi aşağıda eklediğim sadece gözüktü
            //Console.WriteLin2e(isimler[0]);


            List<string> isimler2 = new List<string> { "rukiye", "tuğba", "yasemin", "nefise" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
        }
    }
}
