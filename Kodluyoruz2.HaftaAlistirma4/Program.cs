using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodluyoruz2.HaftaAlistirma4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string sesliHarfler = "aeıioöuü";

            int sayac = 0;

            for (int i = 0; i <cumle.Length; i++)
            {
                if (sesliHarfler.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("{0} sesli harf var", sayac);
            Console.ReadLine();
        }
    }
}
