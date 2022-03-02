using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodluyoruz2.HaftaAlistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 3 ==0 &&  i % 7 ==0)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            Console.ReadKey();
        }
    }
}
