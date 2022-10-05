using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Invoice
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
         public E_Invoice.Form3 frm3;
       

        private void manuelgiris_CheckedChanged(object sender, EventArgs e)
        {
            if (manuelgiris.Checked==true)
            {
                txturunhizmet_tutar.ReadOnly = false;
                txtodenecek_tutar.ReadOnly = false;
                txtvergihariç_tutar.ReadOnly = false;
                txtvergidahil_tutar.ReadOnly = false;
                txtkdv_tutar.ReadOnly = false;
                txtiskonto_tutar.ReadOnly = false;
            }
            else
            {
                txturunhizmet_tutar.ReadOnly = true;
                txtodenecek_tutar.ReadOnly = true;
                txtvergihariç_tutar.ReadOnly = true;
                txtvergidahil_tutar.ReadOnly = true;
                txtkdv_tutar.ReadOnly = true;
                txtiskonto_tutar.ReadOnly = true;
            }
           
        }

      public void faturahesap_Click(object sender, EventArgs e)
        {
            //İslemler.txtbirimfiyat = Convert.ToDouble(txtbirimfiyat.Text);
            //İslemler.txturunmiktar = Convert.ToDouble(txturunmiktar.Text);
            //İslemler.txtiskontoyuzde = Convert.ToInt32(txtiskontoyuzde.Text);
            //İslemler.FaturaHesapla();
            //txtkdvtl.Text = İslemler.b.ToString();
            //txtiskontotl.Text = İslemler.c.ToString();
            //txttopfiyat.Text = İslemler.d.ToString();


            double birimfiyat = Convert.ToDouble(txtbirimfiyat.Text);
            double miktar = Convert.ToDouble(txturunmiktar.Text);
            double iskonto = Convert.ToDouble(txtiskontoyuzde.Text);
            double a = birimfiyat * miktar;
            double kdv = 0;

            if (iskonto.ToString() == txtiskontoyuzde.Text.ToString())
            {
                iskonto = (a * iskonto) / 100;
                a = a - iskonto;
            }

            if (cmbkdvyuzde.Text == 18.ToString())
            {
                kdv = a * 0.18;
                a = a + kdv;
            }
            if (cmbkdvyuzde.Text == 8.ToString())
            {

                kdv = a * 0.08;
                a = a + kdv;
            }
            if (cmbkdvyuzde.Text == 1.ToString())
            {

                kdv = a * 0.01;
                a = a + kdv;
            }
            if (cmbkdvyuzde.Text == 0.ToString())
            {
                kdv = a;
                a = a + kdv;
            }

            txtkdvtl.Text = kdv + "tl";
            txtiskontotl.Text = iskonto + "tl";
            txttopfiyat.Text = a.ToString() + kdv;
        }

        private void txtiskonto_tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
    
}
