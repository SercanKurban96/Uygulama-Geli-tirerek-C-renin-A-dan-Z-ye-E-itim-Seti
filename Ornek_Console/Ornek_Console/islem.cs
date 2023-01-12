using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class islem
    {
        public int topla(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sayi3);
            return sayi3;
        }

        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }

        public int Toplama(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public double Bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
