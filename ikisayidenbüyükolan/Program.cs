using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikisayidenbüyükolan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bu program iki sayıdan büyük olana karar verir");
            Console.Write( "sayı1 :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sayı2 :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2)
             {
                Console.WriteLine("büyük olan:"+sayi1);
               Console.WriteLine($"büyük olan sayı {sayi1}");
              Console.WriteLine($"küçük olan sayı {sayi2}");

            }
            else
            {
                Console.WriteLine( "büyük  olan :"+sayi2);
               Console.WriteLine($"küçük olan sayı {sayi1}");
            }
            //if ve else cümlelerinden sonra tek satırlık bir işlem yapılacaksa kod  blokları kullanmadan yazılabilir.

            Console.ReadKey();




        }
    }
}
