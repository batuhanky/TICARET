using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dış_ticaret
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static byte i = 0;
        public static string[] kullanici_adi = new string[20];
        public static string[] kullanici_şifre = new string[20];
        public static string[] kullanici_mail = new string[20];

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = cinsiyet.Images[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = cinsiyet.Images[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_adi[i] = textBox1.Text;
            kullanici_şifre[i] = textBox2.Text;
            kullanici_mail[i] = textBox3.Text;
            i++;
            Form1 giriş = new Form1();
            giriş.Show();
            Hide();
        }

    }
}
