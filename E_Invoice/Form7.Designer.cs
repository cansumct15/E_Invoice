
namespace E_Invoice
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.lbl_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_minimized);
            this.panel1.Controls.Add(this.lbl_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 150);
            this.panel1.TabIndex = 1;
            // 
            // btn_minimized
            // 
            this.btn_minimized.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimized.Image")));
            this.btn_minimized.Location = new System.Drawing.Point(1183, 36);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.Size = new System.Drawing.Size(49, 44);
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
            this.lbl_exit.Location = new System.Drawing.Point(1238, 36);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(49, 44);
            this.lbl_exit.TabIndex = 14;
            this.lbl_exit.UseVisualStyleBackColor = false;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oluştur/Düzenle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(0, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ön Ekleri";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Belge Türü";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(431, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ön Ek";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(819, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "İşlemler";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kayıt Bulunamadı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btn_geri);
            this.panel2.Controls.Add(this.btn_ileri);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(39, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 91);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(329, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kayıt Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(449, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 38);
            this.textBox1.TabIndex = 4;
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(618, 30);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(39, 38);
            this.btn_ileri.TabIndex = 5;
            this.btn_ileri.Text = ">";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(526, 30);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(39, 38);
            this.btn_geri.TabIndex = 6;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "5/sayfa",
            "10/sayfa",
            "20/sayfa",
            "50/sayfa",
            "100/sayfa"});
            this.comboBox1.Location = new System.Drawing.Point(685, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 39);
            this.comboBox1.TabIndex = 2;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button lbl_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}