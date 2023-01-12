using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba");
            //Console.Write("Dünya");

            //string kelime;
            //kelime = "6 Ekim";
            //Console.WriteLine(kelime);

            //int sayi = 5;
            //Console.Write(sayi);

            //Mesaj msj = new Mesaj();
            //msj.metin();

            //Kisiler ks = new Kisiler();
            //ks.kisilistesi("merhaba");

            //Kisiler ks = new Kisiler();
            ////ks.kisilistesi("Sercan KURBAN");
            ////ks.kisilistesi("Ahmet KARACA");
            //string ads;
            //Console.Write("İsim girin: ");
            //ads = Console.ReadLine();
            //ks.kisilistesi(ads);

            //Kisiler ks = new Kisiler();
            //string ad, soyad, meslek;
            //int yas;
            //Console.Write("Adınızı giriniz: ");
            //ad = Console.ReadLine();
            //Console.Write("Soyadınızı giriniz: ");
            //soyad = Console.ReadLine();
            //Console.Write("Yaşınızı giriniz: ");
            //yas = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mesleğinizi giriniz: ");
            //meslek = Console.ReadLine();
            //ks.kisilistesi(ad, soyad, yas, meslek);

            //islem isl = new islem();
            //isl.topla(7, 6);
            //isl.topla(4, 5);

            //Console.WriteLine("\n\n\n");
            //isl.kare(6);

            //islem isl = new islem();
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Toplam: " + isl.Toplama(sayi1,sayi2));
            //Console.WriteLine("Fark: " + isl.Cikarma(sayi1, sayi2));
            //Console.WriteLine("Çarpım: " + isl.Carpma(sayi1, sayi2));
            //Console.WriteLine("Bölüm: " + isl.Bolme(sayi1, sayi2));

            //string blg;
            //Console.Write("Ad - Kulüp: ");
            //blg = Console.ReadLine();
            //Ogrenci ogr = new Ogrenci(blg);

            //Console.Write("Adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı giriniz: ");
            //string soyad = Console.ReadLine();
            //Console.Write("Yaşınızı giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mesleğinizi giriniz: ");
            //string meslek = Console.ReadLine();
            //Ogrenci ogr = new Ogrenci(ad, soyad, yas, meslek);

            Kimlik kml = new Kimlik();
            kml.AD = "Sercan";
            kml.SOYAD = "Kurban";
            kml.MEMLEKET = "Erzincan";
            kml.YAS = 26;
            kml.CINSIYET = 'E';
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);

            Console.Read(); 
        }
    }
}
