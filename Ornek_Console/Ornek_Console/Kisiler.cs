using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Kisiler
    {
        //public void kisilistesi()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i + ". Kişi");
        //    }
        //}

        //public void kisilistesi(string ad)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i + ad);
        //    }
        //}

        //public void kisilistesi(string adsoyad)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(adsoyad);
        //    }
        //}

        public void kisilistesi(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);
            Console.WriteLine(meslek);
        }
    }
}
