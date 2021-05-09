using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcaseornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gün no (1-7):");
            int no = Convert.ToInt32(Console.ReadLine());
            string gun;
            switch (no)
            {
                case 1 :
                    gun = "PAZARTESİ";
                    break;
                case 2:
                    gun = "SALI";
                    break;
                case 3:
                    gun = "ÇARŞAMBA";
                    break;
                case 4:
                    gun = "PERŞEMBE";
                    break;
                case 5:
                    gun = "CUMA";
                    break;
                case 6:
                    gun = "CUMARTESİ";
                    break;
                case 7:
                    gun = "PAZAR";
                    break;
                default:
                    gun = "#HAT#";
                    break;
            }
            Console.WriteLine(gun);
            Console.ReadKey();

        }
    }
}
