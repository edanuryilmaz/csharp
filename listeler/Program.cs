using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //listeler diziler giib ancak boyutları değiştirilebilir
            List<int> sayilar = new List<int>() { 3, 5, 7 };
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.Write(sayilar[i]+" ");
            }

            Console.WriteLine("");

            //listenin başına 99 ekle 
            sayilar.Insert(0, 99);
            //listenin sonuna 77 ekle
            sayilar.Add(77);
            //listenin 2.sıradaki elemanını 1 artır
            sayilar[1]++;
            //listedeki ilk gördüğün 5 elemanı sil 
            sayilar.Remove(5);
            //listenin ilk elemanını sil 
            sayilar.RemoveAt(0);
            


            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi + " ");
            }




            Console.ReadKey();

















        }
    }
}
