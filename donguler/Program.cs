using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "programlamaya başlangıç için temel kurs";
            //string kurs3 = "java";

            string[] kurslar = new string[] { "1-yazılım geliştirici yetiştirme kampı", "2-programlamaya başlangıç için temel kurs", "3-java","4-python","5-c++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }
            Console.WriteLine("-----for bitti-----");

            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("-----sayfa sonu - footer------");
        }
    }
}
