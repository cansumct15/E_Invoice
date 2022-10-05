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
    public partial class Form4 : Form
    {
      
       
        public Form4()
        {
            InitializeComponent();
        }
       
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_yeniolustur_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void lbl_faturano_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
