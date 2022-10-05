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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
