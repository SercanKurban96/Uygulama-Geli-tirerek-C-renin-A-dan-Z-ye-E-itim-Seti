using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Pratik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            label1.Text = toplam.ToString();*/

            int toplam = 0;
            for (int i = 2; i <= 10; i+=2)
            {
                toplam += i;
            }
            label2.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 ile 10 arasında 3'e tam bölen sayılar
            /*for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }*/

            // 1 ile 100 arasında 5'e ve 7'ye tam bölen sayılar
            /*for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }*/

            // Klavyeden girilen sayıya kadar listeleyen program
            /*int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                listBox1.Items.Add(i);
            }*/

            // Klavyeden girilen sayının tam bölenlerini veren program
            /*int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }*/

            // Klavyeden girilen sayının faktöriyelini alan program
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            int faktoriyel = 1;
            for (int i = 1; i <= sayi ; i++)
            {
                faktoriyel *= i;
                listBox1.Items.Add(faktoriyel);
            }
        }
    }
}
