using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int sayi;
            sayi = 24;
            label1.Text = sayi.ToString();*/

            /*int sayi1, sayi2, toplam;
            sayi1 = 5; 
            sayi2 = 9;
            toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();*/

            //Bir kenarı girilen karenin alan ve çevresini hesaplayan program
            /*int kenar, alan, cevre;
            kenar = 3;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;*/

            //Dikdörtgende alan ve çevre hesabı yapan program
            /*int kisaKenar, uzunKenar, alan, cevre;
            kisaKenar = 10;
            uzunKenar = 20;
            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;*/

            //3 sınav notu girilen öğrencinin ortalamasını hesaplayan program
            int sinav1, sinav2, sinav3, ortalama;
            sinav1 = 55;
            sinav2 = 65;
            sinav3 = 80;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label1.Text = ortalama.ToString();

        }
    }
}
