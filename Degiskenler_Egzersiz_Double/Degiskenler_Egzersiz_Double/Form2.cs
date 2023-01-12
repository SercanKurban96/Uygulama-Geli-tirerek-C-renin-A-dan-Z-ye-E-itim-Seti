using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Egzersiz_Double
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi;
            double fiyat, kdvli8, kdvli18;
            urunAdi = textBox1.Text;
            fiyat = Convert.ToDouble(textBox2.Text);
            kdvli8 = (fiyat * 0.08) + fiyat;
            kdvli18 = (fiyat * 0.18) + fiyat;
            listBox1.Items.Add(urunAdi + " KDV'li Fiyat (%8): " + kdvli8 + " KDV'li Fiyat (%18): " + kdvli18);
        }
    }
}
