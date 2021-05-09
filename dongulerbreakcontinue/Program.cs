using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongulerbreakcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den 10 a sayıları yazdır 7 hariç 
            for (int i = 0; i <=10; i++)
            {
                if (i == 7) continue;
                               
                Console.Write(i+ "  ");
            }
            Console.WriteLine("");
            Console.WriteLine("//1 den 10 e kadar olan sayıları yazdır sayı hem 2 hem 3 e bölünüyorsa  döngüyü sonlandır ");
            
            for (int i = 1; i <=10 ; i++)
            {
                Console.Write(i + " ");
                if (i % 2 == 0 && i % 3 == 0)
                    break;//for u terket 

            }

            Console.WriteLine();
            Console.ReadLine();







        }
    }
}
