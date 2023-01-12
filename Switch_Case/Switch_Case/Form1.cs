using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int ay = Convert.ToInt32(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "Şubat";break;
                case 3: label2.Text = "Mart";break;
                case 4: label2.Text = "Nisan";break;
                case 5: label2.Text = "Mayıs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;
                default: label2.Text = "Tanımsız Ay"; break;
            }*/

            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "ilkbahar":
                    label2.Text = "Mart - Nisan - Mayıs"; break;
                case "yaz":
                    label2.Text = "Haziran - Temmuz - Ağustos"; break;
                case "sonbahar":
                    label2.Text = "Eylül - Ekim - Kasım"; break;
                case "kış":
                    label2.Text = "Aralık - Ocak - Şubat"; break;
                default:
                    label2.Text = "Tanımsız Mevsim";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Klavyeden girilen sembole göre iki sayı üstünde aritmetik işlem yapan program.
            // Semboller + - * /

            double sayi1, sayi2;
            string islem;
            sayi1 = Convert.ToDouble(textBox2.Text);
            sayi2 = Convert.ToDouble(textBox3.Text);
            islem = textBox4.Text;
            switch (islem)
            {
                case "+":
                    double toplam = sayi1 + sayi2;
                    label6.Text = toplam.ToString();
                    break;
                case "-":
                    double fark = sayi1 - sayi2;
                    label6.Text = fark.ToString();
                    break;
                case "*":
                    double carpim = sayi1 * sayi2;
                    label6.Text = carpim.ToString();
                    break;
                case "/":
                    double bolum = sayi1 / sayi2;
                    label6.Text = bolum.ToString("0.00");
                    break;
                default:
                    label6.Text = "Tanımsız Sembol";
                    break;
            }
        }
    }
}
