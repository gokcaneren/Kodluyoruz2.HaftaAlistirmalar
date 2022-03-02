using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodluyoruz2.HaftaAlistirma7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ekrana yazdırılacak metni giriniz:");
            string metin = Console.ReadLine();
            Console.Write("Metnin ekrana kaç kere yazdırılacağını giriniz:");
            int sayac = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine(metin);
            }

            Console.ReadKey();
        }
    }
}
