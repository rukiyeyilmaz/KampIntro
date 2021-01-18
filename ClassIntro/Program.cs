using System;

namespace ClassIntro
{
    class Program {
        static void Main(string[] args)
    {

        Kurs Kurs1 = new Kurs();
        Kurs1.egitmeni = "rukye";
        Kurs1.izlenmeorani = 12;
        Kurs1.KursAdi = "yazilim";

        Kurs Kurs2 = new Kurs();
        Kurs2.egitmeni = "tugba";
        Kurs2.izlenmeorani = 10;
        Kurs2.KursAdi = "kvkk";

        Kurs Kurs3 = new Kurs();
        Kurs3.egitmeni = "yasmn";
        Kurs3.izlenmeorani = 120;
        Kurs3.KursAdi = "yemek";

        // Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.egitmeni);
        //Console.WriteLine(Kurs2);
        //sConsole.WriteLine(Kurs3);

        Kurs[] kurslar = new Kurs[] { Kurs1, Kurs2, Kurs3 };

        foreach (var benimkurslar in kurslar)
        {
            Console.WriteLine(benimkurslar.KursAdi + " : " + benimkurslar.egitmeni);
        }
    }
        }
 }
    


    class Kurs
    {
        public string KursAdi { get; set; }

        public string egitmeni { get; set; }

        public int izlenmeorani { get; set; }
    }

