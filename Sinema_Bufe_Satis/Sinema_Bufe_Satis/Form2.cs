using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, alan, cevre;
            kisaKenar = Convert.ToInt32(TxtKisaKenar.Text);
            uzunKenar = Convert.ToInt32(TxtUzunKenar.Text);
            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);
            LblDikdortgenAlan.Text = alan.ToString();
            LblDikdortgenCevre.Text = cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r, alan, cevre;
            r = Convert.ToDouble(TxtYaricapi.Text);
            alan = Math.PI * r * r;
            cevre = 2 * Math.PI * r;
            LblDaireAlan.Text = alan.ToString("0.00");
            LblDaireCevre.Text = cevre.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ortalama;
            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, toplam, fark, carpim, bolum;
            s1 = Convert.ToDouble(TxtSayi1.Text);
            s2 = Convert.ToDouble(TxtSayi2.Text);
            s3 = Convert.ToDouble(TxtSayi3.Text);
            toplam = s1 + s2 + s3;
            fark = s1 - s2 - s3;
            carpim = s1 * s2 * s3;
            bolum = s1 / s2 / s3;
            LblToplam.Text = toplam.ToString();
            LblFark.Text = fark.ToString();
            LblCarpim.Text = carpim.ToString();
            LblBolum.Text = bolum.ToString();
        }
    }
}
