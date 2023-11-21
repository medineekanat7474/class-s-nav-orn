using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classsinav_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinav matematik1=new sinav();
            matematik1.yazili1 = Convert.ToDouble(txtYazili1.Text);
            matematik1.yazili2 = Convert.ToDouble(txtYazili2.Text);

            lblOrtalama.Text = "ORTALAMANIZ:  " + matematik1.OrtalamaHesapla();

            if (matematik1.OrtalamaHesapla() < 50)
            {
                label3.Text = "kaldı";
            }
            else
            {
                label3.Text = "geçti";
            }
        }
    }
}
