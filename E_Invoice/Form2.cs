using E_Invoice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Invoice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            anasayfa1.BringToFront();
        }
        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");//araçlar kısmındaki hesap makinesini açmayı sağlar
        }
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kolaysoft Portal Penceresi \n 1.0.0", "Kolaysoft Portal Penceresi");
        }

        private void btn_eirsaliye_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            ayarlar.Image = Resources.down_arrow;
            if (PanelAyar.Height == 283)
            {
                PanelAyar.Height = 105;
            }
            else
            {
                ayarlar.Image = Resources.up_arrow;
                PanelAyar.Height = 283;
            }
        }
        private void Form_2(object sender, EventArgs e)
        {
            PanelAyar.Height = 105;
        }

        private void edonusum_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void istek_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
       
        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
        private void btn_vknkisitlamaa_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }
        private void btn_belgeonek_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void btn_vknkisitlamaa_Click_1(object sender, EventArgs e)
        {
            new Form5().Show();
        }
        private void btn_firmaprof_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        private void cikis_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
