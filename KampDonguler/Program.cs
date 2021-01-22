using System;

namespace KampDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "programlamaya giriş kursu";
            string kurs3 = "java";
            

            //array-dizi
            string[] kurslar = new string[] { "yazılım geliştirici kampı", "programlamaya giriş kursu", "java" };            

                for (int i= 0; i < 3; i++) 
                { 
                
                    Console.WriteLine(kurslar[i]);
                }
                Console.WriteLine("for bitti");

                foreach(string kurs in kurslar) // dizi temelli yapilari tek tek dönmeye yariyor
                {
                Console.WriteLine(kurs);
                }

                Console.WriteLine("sayfa sonu-footer");
              

        }
    }
    
}

