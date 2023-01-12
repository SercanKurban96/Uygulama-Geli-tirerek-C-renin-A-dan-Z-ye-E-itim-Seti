using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "Sercan")
            {
                label1.Text = "Doğru";
            }
            else
            {
                label1.Text = "Yanlış";
            }*/

            /*int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi == 5)
            {
                label1.Text = "Doğru";
            }
            else
            {
                label1.Text = "Yanlış";
            }*/

            /*int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                label1.Text = "Çift";
            }
            else
            {
                label1.Text = "Tek";
            }*/

            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi >= 10 || sayi % 2 == 0)
            {
                label1.Text = "10'dan büyük veya çift";
            }
            else
            {
                label1.Text = "10'dan büyük değil ya da çift değil";
            }
        }
    }
}
