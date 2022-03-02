using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;

namespace Kodluyoruz2.HaftaAlistirma6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int tek = 0;
            int cift = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                sayi = rnd.Next(1, 1000);
                Console.WriteLine(sayi);
                if (sayi % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
            }
            Console.WriteLine("{0} Tek sayı",tek);
            Console.WriteLine("{0} Çift sayı", cift);

            Console.ReadKey();
        }
    }
}
