using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace dış_ticaret
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();

            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";

            var xmldoc = new XmlDocument();

            xmldoc.Load(bugun);

            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Date"].Value);
            tarih_form.Text = tarih.ToShortDateString();
            saat.Text = DateTime.Now.ToLongTimeString();

            string usd_al = xmldoc.SelectSingleNode("Tarih_Date/ Currency [@Kod='USD']/ BanknoteBuying").InnerXml;
            string eur_al = xmldoc.SelectSingleNode("Tarih_Date/ Currency [@Kod='EUR']/ BanknoteBuying").InnerXml;
            string gbp_al = xmldoc.SelectSingleNode("Tarih_Date/ Currency [@Kod='GBP']/ BanknoteBuying").InnerXml;

            u_al.Text = usd_al;
            eu_al.Text = eur_al;
            bp_al.Text = gbp_al;


            string usd_sat = xmldoc.SelectSingleNode("Tarih_Date/ Currency [@Kod='USD']/ BanknoteSelling").InnerXml;
            string eur_sat = xmldoc.SelectSingleNode("Tarih_Date/ Currency [@Kod='EUR']/ BanknoteSelling").InnerXml;
            string gbp_sat = xmldoc.SelectSingleNode("Tarih_Date/ Currency [@Kod='GBP']/ BanknoteSelling").InnerXml;

            u_sat.Text = usd_sat;
            eu_sat.Text = eur_sat;
            bp_sat.Text = gbp_sat;

            double Usd_Al_Birim = Convert.ToDouble(usd_al);
            double Eur_Al_Birim = Convert.ToDouble(eur_al);
            double Gbp_Al_Birim = Convert.ToDouble(gbp_al);

            double Usd_Sat_Birim = Convert.ToDouble(usd_sat);
            double Eur_Sat_Birim = Convert.ToDouble(eur_sat);
            double Gbp_Sat_Birim = Convert.ToDouble(gbp_sat);

            if(Usd_Al_Birim > Usd_Sat_Birim)
            {
                usd_pic.Image = durum_resim.Images[0];
            }
            else
            {
                usd_pic.Image = durum_resim.Images[1];
            }

            if (Eur_Al_Birim > Eur_Sat_Birim)
            {
                eur_pic.Image = durum_resim.Images[0];
            }
            else
            {
                eur_pic.Image = durum_resim.Images[1];
            }

            if (Gbp_Al_Birim < Gbp_Sat_Birim)
            {
                gbp_pic.Image = durum_resim.Images[1];
            }
            else
            {
                gbp_pic.Image = durum_resim.Images[0];
            }



        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
