using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekmiciftmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "sayı giriniz" );
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool ciftmi = sayi % 2 == 0;
            string sonuc = ciftmi ? "çift" : "tek";

            Console.WriteLine( "girdiğiniz sayı bir "+ sonuc +"sayıdır" );
            Console.WriteLine($"girdiğiniz sayı bir  {sonuc} sayıdır");
            Console.ReadKey();
        }
    }
}
