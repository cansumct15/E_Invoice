
namespace E_Invoice
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.lbl_exit = new System.Windows.Forms.Button();
            this.btn_onekduzenle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_kapat = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_onekduzenle);
            this.panel1.Controls.Add(this.btn_minimized);
            this.panel1.Controls.Add(this.lbl_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 150);
            this.panel1.TabIndex = 1;
            // 
            // btn_minimized
            // 
            this.btn_minimized.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimized.Image")));
            this.btn_minimized.Location = new System.Drawing.Point(982, 34);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.Size = new System.Drawing.Size(48, 44);
            this.btn_minimized.TabIndex = 16;
            this.btn_minimized.UseVisualStyleBackColor = false;
            this.btn_minimized.Click += new System.EventHandler(this.btn_minimized_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_exit.FlatAppearance.BorderSize = 0;
            this.lbl_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_exit.Image = ((System.Drawing.Image)(resources.GetObject("lbl_exit.Image")));
            this.lbl_exit.Location = new System.Drawing.Point(1037, 34);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(48, 44);
            this.lbl_exit.TabIndex = 14;
            this.lbl_exit.UseVisualStyleBackColor = false;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // btn_onekduzenle
            // 
            this.btn_onekduzenle.AutoSize = true;
            this.btn_onekduzenle.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_onekduzenle.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_onekduzenle.Location = new System.Drawing.Point(50, 34);
            this.btn_onekduzenle.Name = "btn_onekduzenle";
            this.btn_onekduzenle.Size = new System.Drawing.Size(202, 33);
            this.btn_onekduzenle.TabIndex = 2;
            this.btn_onekduzenle.Text = "Ön Ek Düzenle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Belge Türü:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Müstahsil Makbuzu",
            "Serbest Meslek Makbuzu",
            "E-Döviz",
            "E-Fatura",
            "E-Arşiv",
            "E-İrsaliye"});
            this.comboBox1.Location = new System.Drawing.Point(197, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(833, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Belge Türü Seçiniz...";
            // 
            // lbl_kapat
            // 
            this.lbl_kapat.BackColor = System.Drawing.Color.Gray;
            this.lbl_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_kapat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kapat.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_kapat.Image = ((System.Drawing.Image)(resources.GetObject("lbl_kapat.Image")));
            this.lbl_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_kapat.Location = new System.Drawing.Point(50, 278);
            this.lbl_kapat.Name = "lbl_kapat";
            this.lbl_kapat.Size = new System.Drawing.Size(117, 42);
            this.lbl_kapat.TabIndex = 19;
            this.lbl_kapat.Text = "İPTAL";
            this.lbl_kapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_kapat.UseVisualStyleBackColor = false;
            this.lbl_kapat.Click += new System.EventHandler(this.lbl_kapat_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.Location = new System.Drawing.Point(889, 268);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(141, 40);
            this.btn_kaydet.TabIndex = 32;
            this.btn_kaydet.Text = "TAMAM";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 343);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.lbl_kapat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Text = "Form10";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_onekduzenle;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button lbl_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button lbl_kapat;
        private System.Windows.Forms.Button btn_kaydet;
    }
}