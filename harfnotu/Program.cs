using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harfnotu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("bu progra sınavdan aldığınız nota göre bir harf notu verir");
            /* 
             * 0-44 F
             * 45-69 D
             * 70-79 C
             * 80-89 B
             * 90-100 A
             */
            Sor:
            Console.WriteLine("Sınavdan aldığınız not:");
            decimal puan = Convert.ToDecimal(Console.ReadLine());
            char harfnotu;
            if (puan < 0 || puan > 100)
            {
                Console.WriteLine("hatalı değer girdiniz");
                goto Sor;
            }
            else if (puan < 45)
            {
                harfnotu = 'F';
            }
            else if (puan < 70)
            {
                harfnotu = 'D';
            }
            else if (puan < 80)
            {
                harfnotu = 'C';
            }
            else if (puan < 90)
            {
                harfnotu = 'B';
            }
            else
                harfnotu = 'A';

            Console.WriteLine("HARF NOTU    "+ harfnotu);







            Console.WriteLine("programdan çıkmak için bir tuşa basınız" );
            Console.ReadKey();
        }
    }
}
