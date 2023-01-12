using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            //string[] sembol2 = { "+", "-", "*", "/", "#" };

            //Random r = new Random();
            //int s1, s2, s3;
            //s1 = r.Next(0, sembol1.Length);
            //s2 = r.Next(0, sembol2.Length);
            //s3 = r.Next(0, 10);

            //label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();

            string[] sembol1 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
            "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
            "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
            "'","#","$","%","₺","€"};
            string[] sembol2 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
            "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
            "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
            "'","#","$","%","₺","€"};
            string[] sembol3 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
            "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
            "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
            "'","#","$","%","₺","€"};
            string[] sembol4 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
            "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
            "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
            "'","#","$","%","₺","€"};
            string[] sembol5 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
            "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
            "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
            "'","#","$","%","₺","€"};

            Random rastgele = new Random();
            int s1 = rastgele.Next(0, sembol1.Length);
            int s2 = rastgele.Next(0, sembol2.Length);
            int s3 = rastgele.Next(0, sembol3.Length);
            int s4 = rastgele.Next(0, sembol4.Length);
            int s5 = rastgele.Next(0, sembol5.Length);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() +
                sembol4[s4].ToString() + sembol5[s5].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
