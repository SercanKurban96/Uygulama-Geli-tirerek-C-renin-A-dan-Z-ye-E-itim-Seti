using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Ogrenci
    {
        //public Ogrenci(string bilgi)
        //{
        //    //Console.WriteLine("Ad: Sercan");
        //    //Console.WriteLine("Soyad: KURBAN");
        //    //Console.WriteLine("Meslek: Yazılım Geliştiricisi");
        //    Console.WriteLine("Durum: " + bilgi);
        //}

        public Ogrenci(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Meslek: " + meslek);
        }
    }
}
