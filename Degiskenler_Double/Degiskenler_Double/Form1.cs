using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double sayi;
            sayi = 4.25;
            label1.Text = sayi.ToString();*/

            /*double sinav1, sinav2, sinav3, ortalama;
            sinav1 = 55;
            sinav2 = 65;
            sinav3 = 80;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label1.Text = ortalama.ToString("0.00");*/

            double sayi;
            sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();
        }
    }
}
