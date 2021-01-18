using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
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

            }
        }
    }
}
