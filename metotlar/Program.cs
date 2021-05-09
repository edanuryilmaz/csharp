using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            saatyazdir();
            kereyazdir("oley!",3);
            
            string gun = haftanıngunu();
            Console.WriteLine("bugün günlerden :"+gun);
            Console.WriteLine("{0}+{1}={2}",3,5,topla(3,5));

           Console.ReadKey();
        }



        //parametre alan değer döndüren
        static double topla(double sayi1,double sayi2)
        {
            return sayi1 + sayi2;
        }


        //parametre almayan değer döndüren  
        static string haftanıngunu()
        {
            return DateTime.Today.DayOfWeek.ToString();
        }



        //parametre almayan değer döndürmeyen
        static void saatyazdir()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }


        //parametre alan değer döndürmeyen
        //adet =1 demek parametre atanmazsa direkt 1 olarak kabul et demek 
        static void kereyazdir(string metin, int adet=1)
        {
            for (int i = 0; i <adet; i++)
            {
                Console.WriteLine(metin);
            }
        }
        
    }
}
