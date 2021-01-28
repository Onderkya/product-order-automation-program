namespace XYZ_Bilisim
{
    partial class frm_ayarlar
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
            this.btn_kisisel = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_kisiel = new System.Windows.Forms.GroupBox();
            this.grp_sifre = new System.Windows.Forms.GroupBox();
            this.rd_kisisel = new System.Windows.Forms.RadioButton();
            this.rd_sifre = new System.Windows.Forms.RadioButton();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_yeni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tekrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sifre = new System.Windows.Forms.Button();
            this.grp_kisiel.SuspendLayout();
            this.grp_sifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kisisel
            // 
            this.btn_kisisel.Location = new System.Drawing.Point(115, 236);
            this.btn_kisisel.Name = "btn_kisisel";
            this.btn_kisisel.Size = new System.Drawing.Size(234, 33);
            this.btn_kisisel.TabIndex = 21;
            this.btn_kisisel.Text = "Kaydet";
            this.btn_kisisel.UseVisualStyleBackColor = true;
            this.btn_kisisel.Click += new System.EventHandler(this.btn_kisisel_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(115, 185);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(308, 26);
            this.txt_email.TabIndex = 19;
            // 
            // msk_telefon
            // 
            this.msk_telefon.Location = new System.Drawing.Point(115, 137);
            this.msk_telefon.Mask = "(999) 000-0000";
            this.msk_telefon.Name = "msk_telefon";
            this.msk_telefon.Size = new System.Drawing.Size(126, 26);
            this.msk_telefon.TabIndex = 18;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(115, 89);
            this.txt_soyad.MaxLength = 30;
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(234, 26);
            this.txt_soyad.TabIndex = 17;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(115, 41);
            this.txt_ad.MaxLength = 30;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(234, 26);
            this.txt_ad.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-MAİL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "TELEFON:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "AD:";
            // 
            // grp_kisiel
            // 
            this.grp_kisiel.Controls.Add(this.txt_ad);
            this.grp_kisiel.Controls.Add(this.label1);
            this.grp_kisiel.Controls.Add(this.btn_kisisel);
            this.grp_kisiel.Controls.Add(this.label2);
            this.grp_kisiel.Controls.Add(this.label3);
            this.grp_kisiel.Controls.Add(this.txt_email);
            this.grp_kisiel.Controls.Add(this.label4);
            this.grp_kisiel.Controls.Add(this.msk_telefon);
            this.grp_kisiel.Controls.Add(this.txt_soyad);
            this.grp_kisiel.Location = new System.Drawing.Point(5, 50);
            this.grp_kisiel.Name = "grp_kisiel";
            this.grp_kisiel.Size = new System.Drawing.Size(468, 298);
            this.grp_kisiel.TabIndex = 22;
            this.grp_kisiel.TabStop = false;
            // 
            // grp_sifre
            // 
            this.grp_sifre.Controls.Add(this.btn_sifre);
            this.grp_sifre.Controls.Add(this.txt_tekrar);
            this.grp_sifre.Controls.Add(this.label8);
            this.grp_sifre.Controls.Add(this.txt_yeni);
            this.grp_sifre.Controls.Add(this.label7);
            this.grp_sifre.Controls.Add(this.txt_sifre);
            this.grp_sifre.Controls.Add(this.label6);
            this.grp_sifre.Enabled = false;
            this.grp_sifre.Location = new System.Drawing.Point(492, 50);
            this.grp_sifre.Name = "grp_sifre";
            this.grp_sifre.Size = new System.Drawing.Size(468, 298);
            this.grp_sifre.TabIndex = 23;
            this.grp_sifre.TabStop = false;
            // 
            // rd_kisisel
            // 
            this.rd_kisisel.AutoSize = true;
            this.rd_kisisel.Checked = true;
            this.rd_kisisel.Location = new System.Drawing.Point(167, 20);
            this.rd_kisisel.Name = "rd_kisisel";
            this.rd_kisisel.Size = new System.Drawing.Size(187, 24);
            this.rd_kisisel.TabIndex = 24;
            this.rd_kisisel.TabStop = true;
            this.rd_kisisel.Text = "Kişisel Bilgileri Düzenle";
            this.rd_kisisel.UseVisualStyleBackColor = true;
            this.rd_kisisel.CheckedChanged += new System.EventHandler(this.rd_kisiel_CheckedChanged);
            // 
            // rd_sifre
            // 
            this.rd_sifre.AutoSize = true;
            this.rd_sifre.Location = new System.Drawing.Point(654, 20);
            this.rd_sifre.Name = "rd_sifre";
            this.rd_sifre.Size = new System.Drawing.Size(118, 24);
            this.rd_sifre.TabIndex = 25;
            this.rd_sifre.Text = "Şifre Değiştir";
            this.rd_sifre.UseVisualStyleBackColor = true;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(199, 44);
            this.txt_sifre.MaxLength = 23;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(234, 26);
            this.txt_sifre.TabIndex = 23;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "MEVCUT ŞİFRE:";
            // 
            // txt_yeni
            // 
            this.txt_yeni.Location = new System.Drawing.Point(199, 108);
            this.txt_yeni.MaxLength = 23;
            this.txt_yeni.Name = "txt_yeni";
            this.txt_yeni.Size = new System.Drawing.Size(234, 26);
            this.txt_yeni.TabIndex = 25;
            this.txt_yeni.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "YENİ ŞİFRE:";
            // 
            // txt_tekrar
            // 
            this.txt_tekrar.Location = new System.Drawing.Point(199, 172);
            this.txt_tekrar.MaxLength = 23;
            this.txt_tekrar.Name = "txt_tekrar";
            this.txt_tekrar.Size = new System.Drawing.Size(234, 26);
            this.txt_tekrar.TabIndex = 27;
            this.txt_tekrar.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "YENİ ŞİFRE TEKRAR:";
            // 
            // btn_sifre
            // 
            this.btn_sifre.Location = new System.Drawing.Point(199, 236);
            this.btn_sifre.Name = "btn_sifre";
            this.btn_sifre.Size = new System.Drawing.Size(234, 33);
            this.btn_sifre.TabIndex = 22;
            this.btn_sifre.Text = "Kaydet";
            this.btn_sifre.UseVisualStyleBackColor = true;
            this.btn_sifre.Click += new System.EventHandler(this.btn_sifre_Click);
            // 
            // frm_ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 358);
            this.Controls.Add(this.rd_sifre);
            this.Controls.Add(this.rd_kisisel);
            this.Controls.Add(this.grp_sifre);
            this.Controls.Add(this.grp_kisiel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ayarlar_Load);
            this.grp_kisiel.ResumeLayout(false);
            this.grp_kisiel.PerformLayout();
            this.grp_sifre.ResumeLayout(false);
            this.grp_sifre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kisisel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox msk_telefon;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_kisiel;
        private System.Windows.Forms.GroupBox grp_sifre;
        private System.Windows.Forms.RadioButton rd_kisisel;
        private System.Windows.Forms.RadioButton rd_sifre;
        private System.Windows.Forms.Button btn_sifre;
        private System.Windows.Forms.TextBox txt_tekrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_yeni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label6;
    }
}