using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach(Urun urun in urunler) 
            
            { 
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");

            }


            Console.WriteLine("--------Metotlar---------");
            
            //instance - örnek
            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("armut", "yeşil armut", 12, 8);
            sepetmanager.Ekle2("elma", "kırmızı elma", 20, 6);
            sepetmanager.Ekle2("şeftali", "bursa ", 15, 8);

        }
    }
}


//do not repeat yourself(kendini tekrar etme)-clean code-best pratice(doğru uygulama tekniği)