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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="kolaysoft" && txtPassword.Text == "Aa123456")
            {
                MessageBox.Show("Girişiniz gerçekleştiriliyor lütfen bekleyiniz");
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
