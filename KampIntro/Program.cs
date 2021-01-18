using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] kurslar = new string[] {"elbise","ayakkabı","çanta" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(kurslar[i]);
            }
            foreach (string herhangi in kurslar)
                
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Hello");
                Console.WriteLine(herhangi);
            }*/
            int x = 15;
            Console.WriteLine("x=" + x);
            int y = 20;
            Console.WriteLine("y=" + y);
            int z = 0;
            string isim = "rukiye";
            Console.WriteLine("z=" + z);
            isim = Toplama(x, y, isim);
            Console.WriteLine("z=" +z);
        }

        static string Toplama (int a, int b, string name)
        {
            int c=0;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
            c= a + b;
            Console.WriteLine("toplanmış c=" + c);
            return name;
        }
    }
}
