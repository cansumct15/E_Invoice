
namespace E_Invoice
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cmb_listeturu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_kullaniciadi = new System.Windows.Forms.ComboBox();
            this.btn_siraekle = new System.Windows.Forms.Button();
            this.mskd_sira = new System.Windows.Forms.MaskedTextBox();
            this.lblbirimfiyat = new System.Windows.Forms.Label();
            this.btn_cop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.txt_vkntckn = new System.Windows.Forms.TextBox();
            this.lblurunhizmet = new System.Windows.Forms.Label();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_minimized);
            this.panel1.Controls.Add(this.lbl_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 150);
            this.panel1.TabIndex = 0;
            // 
            // lbl_exit
            // 
            this.lbl_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_exit.FlatAppearance.BorderSize = 0;
            this.lbl_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_exit.Image = ((System.Drawing.Image)(resources.GetObject("lbl_exit.Image")));
            this.lbl_exit.Location = new System.Drawing.Point(1238, 12);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(49, 44);
            this.lbl_exit.TabIndex = 14;
            this.lbl_exit.UseVisualStyleBackColor = false;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.cmb_listeturu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmb_kullaniciadi);
            this.groupBox3.Controls.Add(this.btn_siraekle);
            this.groupBox3.Controls.Add(this.mskd_sira);
            this.groupBox3.Controls.Add(this.lblbirimfiyat);
            this.groupBox3.Controls.Add(this.btn_cop);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblmiktar);
            this.groupBox3.Controls.Add(this.txt_vkntckn);
            this.groupBox3.Controls.Add(this.lblurunhizmet);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(8, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1279, 301);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı VKN/TCKN Kısıtları";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.Location = new System.Drawing.Point(1089, 223);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(141, 40);
            this.btn_kaydet.TabIndex = 31;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // cmb_listeturu
            // 
            this.cmb_listeturu.Enabled = false;
            this.cmb_listeturu.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_listeturu.FormattingEnabled = true;
            this.cmb_listeturu.Items.AddRange(new object[] {
            "Gelen e-Fatura",
            "Giden E-Fatura",
            "E-Arşiv Fatura"});
            this.cmb_listeturu.Location = new System.Drawing.Point(711, 156);
            this.cmb_listeturu.Name = "cmb_listeturu";
            this.cmb_listeturu.Size = new System.Drawing.Size(251, 33);
            this.cmb_listeturu.TabIndex = 30;
            this.cmb_listeturu.Text = "Liste Türü Seçiniz";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(711, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 45);
            this.label2.TabIndex = 29;
            this.label2.Text = "Liste Türü";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_kullaniciadi
            // 
            this.cmb_kullaniciadi.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_kullaniciadi.FormattingEnabled = true;
            this.cmb_kullaniciadi.Location = new System.Drawing.Point(46, 156);
            this.cmb_kullaniciadi.Name = "cmb_kullaniciadi";
            this.cmb_kullaniciadi.Size = new System.Drawing.Size(375, 33);
            this.cmb_kullaniciadi.TabIndex = 28;
            this.cmb_kullaniciadi.Text = "Kullanıcı Seçiniz...";
            // 
            // btn_siraekle
            // 
            this.btn_siraekle.BackColor = System.Drawing.Color.Teal;
            this.btn_siraekle.FlatAppearance.BorderSize = 0;
            this.btn_siraekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_siraekle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_siraekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_siraekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_siraekle.Image")));
            this.btn_siraekle.Location = new System.Drawing.Point(1182, 36);
            this.btn_siraekle.Name = "btn_siraekle";
            this.btn_siraekle.Size = new System.Drawing.Size(48, 40);
            this.btn_siraekle.TabIndex = 27;
            this.btn_siraekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_siraekle.UseVisualStyleBackColor = false;
            // 
            // mskd_sira
            // 
            this.mskd_sira.Location = new System.Drawing.Point(15, 152);
            this.mskd_sira.Name = "mskd_sira";
            this.mskd_sira.Size = new System.Drawing.Size(25, 37);
            this.mskd_sira.TabIndex = 12;
            // 
            // lblbirimfiyat
            // 
            this.lblbirimfiyat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblbirimfiyat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblbirimfiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbirimfiyat.Location = new System.Drawing.Point(968, 93);
            this.lblbirimfiyat.Name = "lblbirimfiyat";
            this.lblbirimfiyat.Size = new System.Drawing.Size(262, 45);
            this.lblbirimfiyat.TabIndex = 26;
            this.lblbirimfiyat.Text = "İşlemler";
            this.lblbirimfiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cop
            // 
            this.btn_cop.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cop.FlatAppearance.BorderSize = 0;
            this.btn_cop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cop.Image = ((System.Drawing.Image)(resources.GetObject("btn_cop.Image")));
            this.btn_cop.Location = new System.Drawing.Point(1068, 158);
            this.btn_cop.Name = "btn_cop";
            this.btn_cop.Size = new System.Drawing.Size(47, 33);
            this.btn_cop.TabIndex = 16;
            this.btn_cop.UseVisualStyleBackColor = false;
            this.btn_cop.Click += new System.EventHandler(this.btn_cop_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmiktar
            // 
            this.lblmiktar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmiktar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmiktar.Location = new System.Drawing.Point(427, 93);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(278, 45);
            this.lblmiktar.TabIndex = 1;
            this.lblmiktar.Text = "VKN/TCKN";
            this.lblmiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_vkntckn
            // 
            this.txt_vkntckn.Location = new System.Drawing.Point(427, 156);
            this.txt_vkntckn.Multiline = true;
            this.txt_vkntckn.Name = "txt_vkntckn";
            this.txt_vkntckn.Size = new System.Drawing.Size(278, 33);
            this.txt_vkntckn.TabIndex = 24;
            // 
            // lblurunhizmet
            // 
            this.lblurunhizmet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblurunhizmet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblurunhizmet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblurunhizmet.Location = new System.Drawing.Point(46, 93);
            this.lblurunhizmet.Name = "lblurunhizmet";
            this.lblurunhizmet.Size = new System.Drawing.Size(375, 45);
            this.lblurunhizmet.TabIndex = 2;
            this.lblurunhizmet.Text = "Kullanıcı Adı";
            this.lblurunhizmet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_minimized
            // 
            this.btn_minimized.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimized.Image")));
            this.btn_minimized.Location = new System.Drawing.Point(1183, 12);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.Size = new System.Drawing.Size(49, 44);
            this.btn_minimized.TabIndex = 16;
            this.btn_minimized.UseVisualStyleBackColor = false;
            this.btn_minimized.Click += new System.EventHandler(this.btn_minimized_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskd_sira;
        private System.Windows.Forms.Label lblbirimfiyat;
        private System.Windows.Forms.Button btn_cop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.TextBox txt_vkntckn;
        private System.Windows.Forms.Label lblurunhizmet;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox cmb_listeturu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_kullaniciadi;
        private System.Windows.Forms.Button btn_siraekle;
        private System.Windows.Forms.Button lbl_exit;
        private System.Windows.Forms.Button btn_minimized;
    }
}