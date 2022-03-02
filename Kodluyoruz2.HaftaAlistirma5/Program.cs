using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodluyoruz2.HaftaAlistirma5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 10;
            int toplam = 0;
            for (int i = 0; i < sayac; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz:", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.WriteLine(toplam);

            Console.ReadKey();
        }
    }
}
