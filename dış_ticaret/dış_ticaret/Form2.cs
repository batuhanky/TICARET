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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            slide.Height = aliş.Height;

        }
      
        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            // BOŞ
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slide.Height = aliş.Height;
            slide.Top = aliş.Top;
        }

        private void satiş_Click(object sender, EventArgs e)
        {
            slide.Height = satiş.Height;
            slide.Top = satiş.Top;
        }

        private void kar_Click(object sender, EventArgs e)
        {
            slide.Height = kar.Height;
            slide.Top = kar.Top;
        }

        private void Kur_Click(object sender, EventArgs e)
        {
            
            slide.Height = kur.Height;
            slide.Top = kur.Top;
            
  
        }
    }
}
