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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.mesaj = textBox2.Text;
            //frm.kimden = textBox1.Text;
            //frm.Show();
            //this.Hide();

            Form2 fr = new Form2();
            fr.ad = textBox1.Text;
            fr.soyad = textBox2.Text;
            fr.yas = Convert.ToInt32(textBox3.Text);
            fr.Show();
            this.Hide();
        }
    }
}
