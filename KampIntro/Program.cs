using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenligi
            //Do not repeat yourself=kendini tekrarlama
            //deger tutucu,alias kategoriEtiketi aliastir
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; //veri kaynağından gelir
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Azalış butonu"); 

            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
