﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string metin;
            metin = "Merhaba, bugün 27 Eylül 2022 Salı";
            label1.Text = metin;*/

            /*string adsoyad, meslek;
            adsoyad = "Sercan KURBAN";
            meslek = "Reyon Görevlisi";
            label1.Text = adsoyad;
            label2.Text = meslek;*/

            string sehir;
            sehir = textBox1.Text;
            label1.Text = sehir;
        }
    }
}
