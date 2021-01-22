using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun(); // classın ornegi urun1 adi istege bagli
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2}; // urun arrayi olusturdum //string[] meyveler = new string[] {"Elma","Karpuz"};

            // type safe--tip güvenli çalışacağı veri tipini bilmek ister Urun yerine var yazsan da olur
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("---------Metotlar--------");

            //instance class ornegi olusturduk cagırmak icin
            //encapsulation = kapsülleme ekle2 metodu yerine ekle kullanmak ayri ayri yerine bir düzene sokuyorsun 
            SepetManager sepetManager = new SepetManager(); // instance = örnek
            sepetManager.Ekle(urun1); // sepetManagerdeki ekle metoduunu cagirdim 
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12); // ekle2 tercih edilmemeli stok adedi eklenirse her yerde formati degismen gerek ekle formati iyi classin icindeki urune yeni bi özellik eklersin sadece
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 12);

        }
    }
}
