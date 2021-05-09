using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace değiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenler verileri saklamamız saglar
            int x;
            //ilk değerini akatrdık :initialization
            x = 3;
            //değişken oluşturduk ve değerini atadık 
            int y = 4;
            //+ aritmetik operatörü ile toplama işlemi yapalı
            int toplam = x + y;

            Console.WriteLine("Toplam: "+toplam);
            Console.ReadKey();

        }
    }
}
