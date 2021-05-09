using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = {"edanur","ahmet","baran","alper"};
            //yukarıda 4 elemanlı bir dizi oluşturduk 
            //diziler oluşturulduktan sonra boyutları değiştirilmez


            //dizinin iki nolu elemanını yazdıralım
            Console.Write("iki no lu indekste ki eleman"+isimler[2]);
            Console.WriteLine("dizinin uzunluğu"+isimler.Length);

            //görev: dizinin sol elemanındaki ismi ceren olarak değiştir
            isimler[isimler.Length - 1] = "ceren";

            //görev: dizinin tüm elemanlarını indeks numaralarıyla yazdır
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i ,isimler[i]);
            }

            int baranindeks = Array.IndexOf(isimler, "baran");
            Console.WriteLine("baran ın indeksi " + baranindeks);



            //görev: dizinin elemanlarını alfabetik sırala
            Array.Sort(isimler);

           // Array.Reverse(); dizinin elemanlarını alfabeye göre tersten dizer 
            //isimler adlı dizideki tüm elemanları oge adlı dizie at
           
            foreach (string oge in isimler)
            {
                Console.Write(oge + " ");
            }

            



            Console.ReadKey();
        }
    }
}
