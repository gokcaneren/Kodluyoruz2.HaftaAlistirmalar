using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodluyoruz2.HaftaAlistirma3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet kelime gireceğinizi belirtiniz:");
            int adet = Convert.ToInt32(Console.ReadLine());

            string[] kelimeArr = new string[adet];

            string kelime;

            for (int i = 0; i < adet; i++)
            {
                Console.Write("{0}. Kelimeyi Giriniz:", i+1);
                kelime = Console.ReadLine();
                kelimeArr[i] = kelime;
            }

            Array.Sort(kelimeArr);

            foreach (var kelimeler in kelimeArr)
            {
                Console.WriteLine(kelimeler);
            }


            Console.ReadKey();
        }
    }
}
