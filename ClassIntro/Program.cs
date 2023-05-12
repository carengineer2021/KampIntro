using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "Engin demir";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmeni = "emre deli";
            kurs2.IzlenmeOrani = 50;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmeni = "veli peki";
            kurs3.IzlenmeOrani = 20;

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "ccc";
            kurs4.Egitmeni = "tekin zort";
            kurs4.IzlenmeOrani = 50;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);

                Console.WriteLine("-----sayfa sonu-----");


        }
    }

    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
