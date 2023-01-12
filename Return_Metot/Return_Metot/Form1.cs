using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      /*int Toplam(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        int Carpim(int sayi1, int sayi2, int sayi3) 
        {
            int carp = sayi1 * sayi2 * sayi3;
            return carp;
        }*/

        /*int Kup(int sayi)
        {
            int kup = sayi * sayi * sayi;
            return kup;
        }*/

        int Toplam(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*label1.Text = Toplam(4, 6).ToString();
            label2.Text = Toplam(2, 3).ToString();
            label3.Text = Toplam(4, 8).ToString();*/

            /*int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            label1.Text = Carpim(sayi1, sayi2, sayi3).ToString();*/

            /*int sayi = Convert.ToInt32(textBox1.Text);
            label1.Text = Kup(sayi).ToString();*/

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Toplam(sayi1, sayi2).ToString();
        }
    }
}
