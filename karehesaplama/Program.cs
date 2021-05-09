using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karehesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bu program girilen sayının karesini hesaplar ");
            Console.Write("Sayı:");
            //klavyeden okunan sayılar string olarak alınır
            string cevap = Console.ReadLine();
            //daha sonra tür dönüşümü yaparız 
            int sayi = Convert.ToInt32(cevap);
            int sonuc = sayi * sayi;

            Console.WriteLine("Sonuc:"+sonuc);
            //klavteden herhangi bir tuşa basıladığında kapanır konsol
            Console.ReadKey();
            //klavyeden tuş girmesini iste



        }
    }
}
