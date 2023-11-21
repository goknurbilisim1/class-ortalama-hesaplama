using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sinav matematik1=new Sinav();
            matematik1.yazili1 = Convert.ToDouble(txtYazili1.Text);
            matematik1.yazili2= Convert.ToDouble(txtYazili2.Text);
            lblOrtalama.Text = "Ortalama :" + matematik1.OrtalamaHesaplama();

            if (matematik1.OrtalamaHesaplama() < 50)
            {
                lblDurum.Text = "kaldı";
                lblDurum.ForeColor = Color.Red;
            }
            else
            {
                lblDurum.Text = "Geçti";
                lblDurum.ForeColor= Color.Green;
            }
        }
    }
}
