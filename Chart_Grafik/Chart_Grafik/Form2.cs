using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Grafik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Marmara Bölgesi", 5);
            chart1.Series["Kitap"].Points.AddXY("Ege Bölgesi", 8);
            chart1.Series["Kitap"].Points.AddXY("Akdeniz Bölgesi", 7);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz Bölgesi", 4);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu Bölgesi", 3);
            chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu Bölgesi", 2);
            chart1.Series["Kitap"].Points.AddXY("Güneydoğu Anadolu Bölgesi", 1);
        }
    }
}
