using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Sercan", "Ahmet", "Yusuf", "Ayşe", "Fatma", "Ali" };
            //foreach (string k in kisiler)
            //{
            //    listBox1.Items.Add(k);  
            //}

            //int toplam = 0;
            //int[] sinavlar = { 70, 65, 85, 100, 90 };
            //foreach (int x in sinavlar)
            //{
            //    listBox1.Items.Add(x);
            //    toplam += x;
            //}
            //label1.Text = toplam.ToString();

            //int ortalama = toplam / sinavlar.Length;
            //label2.Text = ortalama.ToString();

            // 10 elemanlı tamsayılı bir dizi içerisinde 4'te tam bölünen sayıları foreach döngüsüyle listeleyin.
            // Aynı soru için bu kez 4'e tam bölünenlerin kaç tane olduğunu listeleyin.
            // Aynı soru için bu kez de 4'e tam bölünen sayıların toplamını hesaplayın.

            int[] sayilar = { 5, 7, 12, 4, 11, 16, 8, 1, 13, 2 };
            int sayac = 0;
            int toplam = 0;
            foreach (int x in sayilar)
            {
                if (x % 4 == 0)
                {
                    sayac++;
                    listBox1.Items.Add(x);
                    toplam += x;
                }
            }
            label1.Text = sayac.ToString();
            label2.Text = toplam.ToString();
            
        }
    }
}
