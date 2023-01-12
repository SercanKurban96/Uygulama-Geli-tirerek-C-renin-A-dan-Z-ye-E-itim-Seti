using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Sercan", "Ahmet", "Yusuf", "Mehmet", "Aslı", "Ayşe", "Fatma" };
            //label1.Text = kisiler[4];

            //int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = sayilar[5].ToString();

            // Ondalıklı değer olan 5 tane dizi oluşturun.
            //double[] ondalikliSayilar = { 5.12, 3.24, 7.81, 4.17, 9.16 };
            //label1.Text = ondalikliSayilar[2].ToString();

            // Char kullanarak 10 tane dizi oluşturun.
            //char[] harfler = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            //label1.Text = harfler[5].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Sivas", "Erzincan", "Bartın" };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            //int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        listBox1.Items.Add(sayilar[i]);
            //    }
            //}

            // Dizi içerisinde 10 tane eleman gönderin, 10'dan büyük ve çift sayıları listeleyin.
            int[] sayilar = { 5, 12, 4, 7, 9, 30, 23, 6, 10, 21 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > 10 && sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
