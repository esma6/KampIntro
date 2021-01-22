using System;

namespace siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 64;

            // Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
