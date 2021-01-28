namespace XYZ_Bilisim
{
    partial class frm_urunEkle
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
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.btn_urunKaydet = new System.Windows.Forms.Button();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(128, 100);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(212, 26);
            this.txt_Fiyat.TabIndex = 1;
            // 
            // btn_urunKaydet
            // 
            this.btn_urunKaydet.Location = new System.Drawing.Point(128, 260);
            this.btn_urunKaydet.Name = "btn_urunKaydet";
            this.btn_urunKaydet.Size = new System.Drawing.Size(212, 45);
            this.btn_urunKaydet.TabIndex = 3;
            this.btn_urunKaydet.Text = "Kaydet";
            this.btn_urunKaydet.UseVisualStyleBackColor = true;
            this.btn_urunKaydet.Click += new System.EventHandler(this.btn_urunKaydet_Click);
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.Location = new System.Drawing.Point(128, 54);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(212, 26);
            this.txt_urunAd.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "FİYAT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "ÜRÜN AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "AÇIKLAMA:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(128, 146);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(212, 88);
            this.txt_aciklama.TabIndex = 2;
            // 
            // frm_urunEkle
            // 
            this.AcceptButton = this.btn_urunKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 360);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.btn_urunKaydet);
            this.Controls.Add(this.txt_urunAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_urunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Button btn_urunKaydet;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aciklama;
    }
}