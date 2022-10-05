using E_Invoice.Properties;
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
//using System.Xml;
//using System.Xml.Linq;
//XDocument xDoc = new XDocument();


//string directory_path = c: \ Windows \ Microsoft.NET \ Framework64 \ vX.X.XXX csc.exe.Global.AppPath + "//XML";
//string file_path = c: \ Windows \ Microsoft.NET \ Framework64 \ vX.X.XXX csc.exe.Global.AppPath + "//XML//Form3.xml";
namespace E_Invoice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void FaturaGetir()
        {
            Form4 frm4 = new Form4();
            frm4.lbl_vkntckn.Text = txt_vkn.Text;
            frm4.lbl_unvan.Text = txt_unvan.Text;
            frm4.lbl_faturatarih.Text = duzen_tarih.Text;
            frm4.lbl_urunhizmet.Text = txturunhizmet.Text;
            frm4.lbl_iskonto.Text = txtiskontotl.Text;
            frm4.lbl_vergihariçtutar.Text = txtbirimfiyat.Text;
            frm4.lbl_odencektutar.Text = txttopfiyat.Text;
            frm4.lbl_senaryoturu.Text = senaryo.SelectedItem.ToString();
            frm4.lbl_faturatur.Text = faturatur.SelectedItem.ToString();
            frm4.textBox4.Text = txt_vkntckn.Text;
            frm4.Show();
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
        public string Deneme()
        {
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
            kdv = Math.Round(kdv, 2);
            txtkdvtl.Text = kdv+ " " ;
            iskonto = Math.Round(iskonto, 2);
            txtiskontotl.Text = iskonto + " ";
            double sonuc = Convert.ToDouble(a);
            sonuc = Math.Round(sonuc, 2);
            txttopfiyat.Text = sonuc.ToString();


            //txttopfiyat.Text = String.Format("{0:0.00}",Math.Round(sonuc,3).ToString());



            //a.Handled = !char.IsDigit(a.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';

            //if (e.KeyChar == ',' && txttopfiyat.Text.IndexOf(",") > -1 || e.KeyChar == '.' && txttopfiyat.Text.IndexOf(".") > -1)
            //    e.Handled = true;

            //if (e.KeyChar == ',' && txttopfiyat.Text.IndexOf(",") < 1)
            //{
            //   txttopfiyat.MaxLength = txttopfiyat.TextLength + 3;
            //}

            return "";
        }


        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void txtmiktar_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void faturahesap_Click(object sender, EventArgs e)
        {
            Deneme();
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void istek_Click(object sender, EventArgs e)
        {
            new Form4().Show();

        }

        private void Form_3(object sender, EventArgs e)
        {
            PanelAyar.Height = 105;
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

        private void anasayfabutton_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void istek_Click_1(object sender, EventArgs e)
        {
            FaturaGetir();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kolaysoft Portal Penceresi \n 1.0.0", "Kolaysoft Portal Penceresi");
        }

        private void btn_vknkisitlamaa_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void btn_firmaprof_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void btn_belgeonek_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void dgrbilgi_Click(object sender, EventArgs e)
        {
            new Form9().Show();
        }

        private void tmlbilgi_Click(object sender, EventArgs e)
        {
            new Form3().Show();
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

        private void radiovkn_CheckedChanged(object sender, EventArgs e)
        {
            txt_vkn.ReadOnly = false;
            txt_vkn.Clear();
            txt_vkntckn.ReadOnly = true;
        }

        private void radiotckn_CheckedChanged(object sender, EventArgs e)
        {

            txt_vkntckn.ReadOnly = false;
            txt_vkntckn.Clear();
            txt_vkn.ReadOnly = true;
        }

        private void manuelgiris_CheckedChanged(object sender, EventArgs e)
        {
            if (manuelgiris.Checked == true)
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Xml 'e dönüştürme Formatı

            XmlTextWriter dosya = new XmlTextWriter(@"fatura.xml",Encoding.UTF8);
            
            dosya.Formatting = Formatting.Indented;

            dosya.WriteStartDocument();
            dosya.WriteStartElement("Invoice", "xmlns: ", "urn: oasis:names: specification:ubl: schema:xsd: CommonExtensionComponents - 2 xmlns = , urn: oasis:names: specification:ubl: schema:xsd: Invoice - 2  xmlns:cac= urn: oasis:names: specification:ubl: schema:xsd: CommonAggregateComponents - 2  xmlns:cbc= urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            dosya.WriteStartElement("ext:UBLExtensions");
            dosya.WriteStartElement("ext:UBLExtension");
            dosya.WriteStartElement("ext:ExtensionContent");
            dosya.WriteElementString("auto-generated_for_wildcard", "");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteElementString("cbc:UBLVersionID", "");
            dosya.WriteElementString("cbc:CustomizationID", "");
            dosya.WriteElementString("cbc:ProfileID", senaryo.Text);
            dosya.WriteElementString("cbc:ID", "");
            dosya.WriteElementString("cbc:CopyIndicator", "");
            dosya.WriteElementString("cbc:UUID", "");
            dosya.WriteElementString("cbc:IssueDate", duzen_tarih.Text);
            dosya.WriteElementString("cbc:IssueTime", duzen_Saat.Text);
            dosya.WriteElementString("cbc:InvoiceTypeCode", faturatur.Text);
            dosya.WriteElementString("cbc:DocumentCurrencyCode", parabirim.Text);
            dosya.WriteElementString("cbc:LineCountNumeric", " ");
            dosya.WriteStartElement("cac:InvoicePeriod");
            dosya.WriteElementString("cbc:StartDate", duzen_tarih.Text);
            dosya.WriteElementString("cbc:EndDate", duzen_tarih.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("Signature");
            dosya.WriteElementString("cbc:ID", "TCKN", txt_vkntckn.Text);
            dosya.WriteStartElement("cac:SignatoryParty");
            dosya.WriteStartElement("cac:PartyIdentification");
            dosya.WriteElementString("cbc:ID", "TCKN", txt_vkntckn.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PostalAddress");
            dosya.WriteElementString("cbc:StreetName", txt_adres.Text);
            dosya.WriteElementString("cac:BuildingNumber", " ");
            dosya.WriteElementString("cbc:CitySubdivisionName", " ");
            dosya.WriteElementString("cbc:CityName", " ");
            dosya.WriteElementString("cbc:PostalZone", " ");
            dosya.WriteStartElement("cac:Country");
            dosya.WriteElementString("cbc:Name", "Türkiye ");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:DigitalSignatureAttachment");
            dosya.WriteStartElement("cac:ExternalReference");
            dosya.WriteElementString("cbc:URL", "#Signature");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:AccountingSupplierParty");
            dosya.WriteStartElement("cac:Party");
            dosya.WriteElementString("cbc:WebsiteURL", txt_web.Text);
            dosya.WriteStartElement("cac:PartyIdentification");
            dosya.WriteElementString("cbc:ID", "TCKN", txt_vkntckn.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PartyName");
            dosya.WriteElementString("cbc:Name", txt_ad.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PostalAddress", txt_vkntckn.Text);
            dosya.WriteElementString("cbc:StreetName", txt_adres.Text);
            dosya.WriteElementString("cbc:BuildingNumber", txt_adres.Text);
            dosya.WriteElementString("cbc:CitySubdivisionName", txt_adres.Text);
            dosya.WriteElementString("cbc:CityName", txt_adres.Text);
            dosya.WriteElementString("cbc:PostalZone", " ");
            dosya.WriteStartElement("cac:Country");
            dosya.WriteElementString("cbc:Name", "Türkiye");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PartyTaxScheme");
            dosya.WriteStartElement("cac:TaxScheme");
            dosya.WriteElementString("cbc:Name", " ");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:Contact");
            dosya.WriteElementString("cbc:Telephone", txt_telefon.Text);
            dosya.WriteElementString("cbc:Telefax", txt_faks.Text);
            dosya.WriteElementString("cbc:ElectronicMail", txt_email.Text);
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:AccountingCustomerParty");
            dosya.WriteStartElement("cac:Party");
            dosya.WriteElementString("cbc:WebSiteURL", " ");
            dosya.WriteStartElement("cac:PartyIdentification");
            dosya.WriteElementString("cbc:ID", "TCKN", txt_vkntckn.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PartyIdentification");
            dosya.WriteElementString("cbc:ID", "TESİSATNO", "");
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PartyIdentification");
            dosya.WriteElementString("cbc:ID", "SAYACNO", " ");
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PostalAddress");
            dosya.WriteElementString("cbc:ID", txt_adres.Text);
            dosya.WriteElementString("cbc:Room", txt_adres.Text);
            dosya.WriteElementString("cbc:StreetName", txt_adres.Text);
            dosya.WriteElementString("cbc:BuildingNumber", txt_adres.Text);
            dosya.WriteElementString("cbc:CitySubdivisionName", txt_adres.Text);
            dosya.WriteElementString("cbc:CityName", txt_adres.Text);
            dosya.WriteElementString("cbc:PostalZone", " ");
            dosya.WriteStartElement("cac:Country");
            dosya.WriteElementString("cbc:Name", "Türkiye");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:Contact");
            dosya.WriteElementString("cbc:ElectronicMail", txt_email.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:Person");
            dosya.WriteElementString("cbc:FirstName", txt_ad.Text);
            dosya.WriteElementString("cbc:FamilyName", txt_soyad.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:PaymentTerms");
            dosya.WriteElementString("cbc:Note", " ");
            dosya.WriteElementString("cbc:PaymentDueDate", duzen_tarih.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:TaxTotal");
            dosya.WriteElementString("cbc:TaxAmount", parabirim.Text, txtkdvtl.Text);
            dosya.WriteStartElement("cac:TaxSubTotal");
            dosya.WriteElementString("cbc:TaxableAmount", parabirim.Text, txtbirimfiyat.Text);
            dosya.WriteElementString("cbc:TaxAmount", parabirim.Text, txtkdvtl.Text);
            dosya.WriteStartElement("cac:TaxCategory");
            dosya.WriteStartElement("cac:TaxScheme");
            dosya.WriteElementString("cbc:TaxTypeCode", "0015");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:LegalMonetaryTotal");
            dosya.WriteElementString("cbc:LineExtensionAmount", parabirim.Text, txtbirimfiyat.Text);
            dosya.WriteElementString("cbc:TaxExclusiveAmount", parabirim.Text, txtbirimfiyat.Text);
            dosya.WriteElementString("cbc:TaxInclusiveAmount", parabirim.Text, txttopfiyat.Text);
            dosya.WriteElementString("cbc:PayableAmount", parabirim.Text, txttopfiyat.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:İnvoiceLine");
            dosya.WriteElementString("cbc:ID", "1");
            dosya.WriteElementString("cbc:InvoicedQuantity", "KWH", " ");
            dosya.WriteElementString("cbc:LineExtensionAmount", parabirim.Text, txttopfiyat.Text);
            dosya.WriteStartElement("cac:AllowanceCharge");
            dosya.WriteElementString("cbc:ChargeIndicator", " ");
            dosya.WriteElementString("cbc:MultiplierFactorNumeric", " ");
            dosya.WriteElementString("cbc:Amount", parabirim.Text, " ");
            dosya.WriteElementString("cbc:BaseAmount", parabirim.Text, txttopfiyat.Text);
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:TaxTotal");
            dosya.WriteElementString("cbc:TaxAmount", parabirim.Text, txtkdvtl.Text);
            dosya.WriteStartElement("cac:TaxSubTotal");
            dosya.WriteElementString("cbc:TaxableAmount", parabirim.Text, txttopfiyat.Text);
            dosya.WriteElementString("cbc:TaxAmount", parabirim.Text, txtkdvtl.Text);
            dosya.WriteElementString("cbc:Percent", txtkdv_tutar.Text);
            dosya.WriteStartElement("cac:TaxCategory");
            dosya.WriteStartElement("cac:TaxScheme");
            dosya.WriteElementString("cbc:Name", " ");
            dosya.WriteElementString("cbc:TaxTypeCode", "");
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:Item");
            dosya.WriteElementString("cbc:Name", "Elektirik Tüketim Bedeli");
            dosya.WriteEndElement();
            dosya.WriteStartElement("cac:Price");
            dosya.WriteElementString("cbc:PrimeAmount", parabirim.Text);
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.WriteEndElement();

            dosya.Close();


            MessageBox.Show("Faturanız Xml Formatında Başarıyla İndirilmiştir.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FaturaGetir(); 
        }

        private void btn_irsaliye_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

      
    }
}
    
    

