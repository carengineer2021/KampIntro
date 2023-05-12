using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {   //tyfe safety - tip güvenliği
            //do not repeat yourself- kendini tekrarlama
            //değer tutucu  alias
            
            String KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarınDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarınDun > dolarBugun) 
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarınDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
           else 
            { 
                Console.WriteLine("değişmedi butonu");
            }
             
            if (sistemeGirisYapmismi == true) 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
           // Console.WriteLine(KategoriEtiketi);

        }
    }
}
