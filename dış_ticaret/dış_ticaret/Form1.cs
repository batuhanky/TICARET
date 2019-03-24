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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte j = Form4.i;
        Boolean kullan = false;
        string[] f1_kullanici_adi = new string[20];
        string[] f1_kullanici_şifre = new string[20];
        string[] f1_kullanici_mail = new string[20];
        private object giriş;

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            for(byte k = 0; k < j; j++)
            {
                f1_kullanici_adi[k] = Form4.kullanici_adi[k];
                f1_kullanici_şifre[k] = Form4.kullanici_şifre[k];
                f1_kullanici_mail[k] = Form4.kullanici_mail[k];
                if(f1_kullanici_adi[k] == textBox1.Text && f1_kullanici_şifre[k] == textBox2.Text)
                {
                }
                    kullan = true;
            }
            if(kullan == true)
            {
                Form2 menü = new Form2();
                menü.Show();
                Hide();
            }

        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            Form4 kullanici_ekle = new Form4();
            kullanici_ekle.Show();
            Hide();
        }
    }
}
