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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public bool TcDogruMu()
        {
            string kimlikno = txt_vkntckn.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                txt_vkntckn.Focus();
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                MessageBox.Show("TC Numarası Geçerli Lütfen Devam Ediniz");
                return true;
            }
            else
            {
                MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
                txt_vkntckn.Focus();
                return false;
            }
        }

        private void dgrbilgi_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Hide();
        }

        private void aliciolustur_Click(object sender, EventArgs e)
        {
            if (radiotckn.Checked == true)
            {
                TcDogruMu();

                if (txt_ad.Text == string.Empty)
                {
                    MessageBox.Show("Ad Alanı Boş Geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_soyad.Text == string.Empty)
                {
                    MessageBox.Show("Soyad Alanı Boş Geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (radiovkn.Checked == true)
            {
                if (txt_vkn.Text.Length < 10)
                {
                    MessageBox.Show("Vkn Alanını 10(on) Haneli Olmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_unvan.Text == string.Empty)
                {
                    MessageBox.Show("Unvan Alanı Boş Geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Giriş Başarılı");
                }
            }
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void istek_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void edonusum_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btn_irsaliye_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }

        private void tmlbilgi_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }
    }
}
