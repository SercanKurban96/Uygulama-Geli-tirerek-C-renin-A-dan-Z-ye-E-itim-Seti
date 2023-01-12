using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac >= 0 && sayac < 30)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if (sayac >= 30 && sayac < 40)
            {
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if (sayac >= 40 && sayac <= 70)
            {
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
            }
            if (sayac == 70)
            {
                sayac = 0;
            }
        }
    }
}
