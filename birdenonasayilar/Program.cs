using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birdenonasayilar
{
    class Program
    {
        static void Main(string[] args)
        {

            //birden ona kadar olan sayıları yazdırma
            int sayi = 1;
            int max = 10;
            //şart doğru olduğu sürece altındaki bloğu çalıştırır
            while (sayi<=max)
            {
                Console.Write(sayi+ " ");
                sayi++;
            }
            Console.WriteLine(" ");

            for (int i =1; i <= max; i++)
            {
                Console.Write(i+ " ");
            }
            Console.ReadKey();


















        }
    }
}
