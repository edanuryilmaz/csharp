using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgiris
{
    class Program
    {
        static void Main(string[] args)
        {

            kisi kisi = new kisi();
            kisi.ad = "edanur";
                kisi.soyad = "yılmaz";
            kisi.yas = 20;

            kisi kisi1 = new kisi();
            kisi1.ad = "ali";
            kisi1.soyad = "yılmaz";
            kisi1.yas = 11;
            kisi kisi2 = new kisi() { ad = "baran", soyad = "ingenc", yas = 23 };

            Console.WriteLine("1.kişinin adı: "+kisi.ad);//ad özelliğinin get ini kullandık 
            Console.WriteLine("2.kişinin yaşı :"+kisi2.yas);//yaş özelliğinin get ini kullandık 
            Console.WriteLine("1.kişinin künyesi :" + kisi.kunye());
            Console.WriteLine("1.kişinin künyesi :" + kisi1.kunye());
            Console.WriteLine("1.kişinin künyesi :" + kisi2.kunye());
            Console.ReadKey();
        }
    }
    public class kisi
    {
        public string ad { get; set; }
        public string soyad{ get; set; }
        public int yas { get; set; }

        public string kunye()
        {
            return ad + " " + soyad + " " + yas;
        }
    }


}
