
namespace E_Invoice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullanici = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minus = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1411, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kullanici
            // 
            this.kullanici.AutoSize = true;
            this.kullanici.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kullanici.Location = new System.Drawing.Point(437, 110);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(147, 30);
            this.kullanici.TabIndex = 1;
            this.kullanici.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.sifre);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.kullanici);
            this.panel1.Location = new System.Drawing.Point(233, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 514);
            this.panel1.TabIndex = 2;
            // 
            // minus
            // 
            this.minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minus.BackgroundImage")));
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minus.Location = new System.Drawing.Point(861, 0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(37, 34);
            this.minus.TabIndex = 12;
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Location = new System.Drawing.Point(895, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(37, 34);
            this.exit.TabIndex = 11;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(768, 303);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 25);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(611, 271);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 29);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Oturumu Açık Tut";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(611, 236);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(599, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(611, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 31);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.Location = new System.Drawing.Point(611, 109);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 31);
            this.txtUsername.TabIndex = 5;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sifre.Location = new System.Drawing.Point(517, 188);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(67, 30);
            this.sifre.TabIndex = 4;
            this.sifre.Text = "Şİfre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 399);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minus;
    }
}

