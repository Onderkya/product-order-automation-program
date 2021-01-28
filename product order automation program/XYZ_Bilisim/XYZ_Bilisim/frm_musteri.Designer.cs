namespace XYZ_Bilisim
{
    partial class frm_musteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.btn_ayarlar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sepet = new System.Windows.Forms.Button();
            this.rch_aciklama = new System.Windows.Forms.RichTextBox();
            this.num_adet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_urunadi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridSepet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI:";
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(117, 24);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(21, 20);
            this.lbl_kullaniciadi.TabIndex = 1;
            this.lbl_kullaniciadi.Text = "...";
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ayarlar.Location = new System.Drawing.Point(1092, 12);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(101, 49);
            this.btn_ayarlar.TabIndex = 2;
            this.btn_ayarlar.Text = "Ayarlar";
            this.btn_ayarlar.UseVisualStyleBackColor = true;
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ayarlar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_kullaniciadi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 78);
            this.panel1.TabIndex = 1;
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(12, 84);
            this.dataGridUrunler.MultiSelect = false;
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.ReadOnly = true;
            this.dataGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUrunler.Size = new System.Drawing.Size(632, 711);
            this.dataGridUrunler.TabIndex = 2;
            this.dataGridUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tutar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_fiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_sepet);
            this.groupBox1.Controls.Add(this.rch_aciklama);
            this.groupBox1.Controls.Add(this.num_adet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_urunadi);
            this.groupBox1.Location = new System.Drawing.Point(658, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 322);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Location = new System.Drawing.Point(119, 256);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.ReadOnly = true;
            this.txt_tutar.Size = new System.Drawing.Size(190, 35);
            this.txt_tutar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "TUTAR:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Location = new System.Drawing.Point(119, 168);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.ReadOnly = true;
            this.txt_fiyat.Size = new System.Drawing.Size(190, 35);
            this.txt_fiyat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "FİYAT:";
            // 
            // btn_sepet
            // 
            this.btn_sepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sepet.Location = new System.Drawing.Point(367, 166);
            this.btn_sepet.Name = "btn_sepet";
            this.btn_sepet.Size = new System.Drawing.Size(158, 125);
            this.btn_sepet.TabIndex = 5;
            this.btn_sepet.Text = "SEPETE AT";
            this.btn_sepet.UseVisualStyleBackColor = true;
            this.btn_sepet.Click += new System.EventHandler(this.btn_sepet_Click);
            // 
            // rch_aciklama
            // 
            this.rch_aciklama.Location = new System.Drawing.Point(22, 67);
            this.rch_aciklama.Name = "rch_aciklama";
            this.rch_aciklama.ReadOnly = true;
            this.rch_aciklama.Size = new System.Drawing.Size(503, 83);
            this.rch_aciklama.TabIndex = 4;
            this.rch_aciklama.Text = "";
            // 
            // num_adet
            // 
            this.num_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_adet.Location = new System.Drawing.Point(119, 212);
            this.num_adet.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_adet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_adet.Name = "num_adet";
            this.num_adet.Size = new System.Drawing.Size(190, 35);
            this.num_adet.TabIndex = 3;
            this.num_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_adet.ValueChanged += new System.EventHandler(this.num_adet_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADET:";
            // 
            // lbl_urunadi
            // 
            this.lbl_urunadi.AutoSize = true;
            this.lbl_urunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunadi.Location = new System.Drawing.Point(17, 22);
            this.lbl_urunadi.Name = "lbl_urunadi";
            this.lbl_urunadi.Size = new System.Drawing.Size(31, 29);
            this.lbl_urunadi.TabIndex = 1;
            this.lbl_urunadi.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridSepet);
            this.groupBox2.Location = new System.Drawing.Point(658, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 281);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEPET";
            // 
            // dataGridSepet
            // 
            this.dataGridSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSepet.Location = new System.Drawing.Point(3, 22);
            this.dataGridSepet.MultiSelect = false;
            this.dataGridSepet.Name = "dataGridSepet";
            this.dataGridSepet.ReadOnly = true;
            this.dataGridSepet.Size = new System.Drawing.Size(532, 256);
            this.dataGridSepet.TabIndex = 0;
            this.dataGridSepet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSepet_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "URUN_ADI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 144;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ADET";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TUTAR";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 113;
            // 
            // Column4
            // 
            this.Column4.HeaderText = " ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = " ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = " ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // btn_onayla
            // 
            this.btn_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onayla.Location = new System.Drawing.Point(661, 720);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(532, 74);
            this.btn_onayla.TabIndex = 5;
            this.btn_onayla.Text = "ONAYLA";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(974, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siparişlerim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 807);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridUrunler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_musteri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_musteri_FormClosing);
            this.Load += new System.EventHandler(this.frm_musteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ayarlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sepet;
        private System.Windows.Forms.RichTextBox rch_aciklama;
        private System.Windows.Forms.NumericUpDown num_adet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_urunadi;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridSepet;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
    }
}