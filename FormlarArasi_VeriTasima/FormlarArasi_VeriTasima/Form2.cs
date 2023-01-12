using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasi_VeriTasima
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //public string mesaj;
        //public string kimden;

        public string ad;
        public string soyad;
        public int yas;
        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = kimden;
            //label2.Text = mesaj;

            comboBox1.Text = ad + soyad + yas;
        }
    }
}
