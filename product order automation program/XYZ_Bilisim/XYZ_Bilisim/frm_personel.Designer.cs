namespace XYZ_Bilisim
{
    partial class frm_personel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_yeniurun = new System.Windows.Forms.Button();
            this.chk_urunler = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.btn_urunSil = new System.Windows.Forms.Button();
            this.btn_urunKaydet = new System.Windows.Forms.Button();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.txt_urunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_stokkaydet = new System.Windows.Forms.Button();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_urunadi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_urunid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridStok = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ayarlar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_yenipersonel = new System.Windows.Forms.Button();
            this.chk_aktif = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cmb_yetki = new System.Windows.Forms.ComboBox();
            this.msk_tlf = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPersonel = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStok)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonel)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 711);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_yeniurun);
            this.tabPage1.Controls.Add(this.chk_urunler);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dataGridUrunler);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ÜRÜN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_yeniurun
            // 
            this.btn_yeniurun.Location = new System.Drawing.Point(625, 80);
            this.btn_yeniurun.Name = "btn_yeniurun";
            this.btn_yeniurun.Size = new System.Drawing.Size(288, 78);
            this.btn_yeniurun.TabIndex = 2;
            this.btn_yeniurun.Text = "Yeni Urun Ekle";
            this.btn_yeniurun.UseVisualStyleBackColor = true;
            this.btn_yeniurun.Click += new System.EventHandler(this.btn_yeniurun_Click);
            // 
            // chk_urunler
            // 
            this.chk_urunler.AutoSize = true;
            this.chk_urunler.Checked = true;
            this.chk_urunler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_urunler.Location = new System.Drawing.Point(625, 16);
            this.chk_urunler.Name = "chk_urunler";
            this.chk_urunler.Size = new System.Drawing.Size(116, 24);
            this.chk_urunler.TabIndex = 4;
            this.chk_urunler.Text = "Aktif Ürünler";
            this.chk_urunler.UseVisualStyleBackColor = true;
            this.chk_urunler.CheckedChanged += new System.EventHandler(this.chk_urunler_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_aciklama);
            this.groupBox2.Controls.Add(this.txt_Fiyat);
            this.groupBox2.Controls.Add(this.btn_urunSil);
            this.groupBox2.Controls.Add(this.btn_urunKaydet);
            this.groupBox2.Controls.Add(this.txt_urunAd);
            this.groupBox2.Controls.Add(this.txt_urunID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(605, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 479);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "AÇIKLAMA:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(96, 157);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(212, 88);
            this.txt_aciklama.TabIndex = 22;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(96, 113);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(212, 26);
            this.txt_Fiyat.TabIndex = 14;
            // 
            // btn_urunSil
            // 
            this.btn_urunSil.Location = new System.Drawing.Point(96, 363);
            this.btn_urunSil.Name = "btn_urunSil";
            this.btn_urunSil.Size = new System.Drawing.Size(212, 45);
            this.btn_urunSil.TabIndex = 13;
            this.btn_urunSil.Text = "Sil";
            this.btn_urunSil.UseVisualStyleBackColor = true;
            this.btn_urunSil.Click += new System.EventHandler(this.btn_urunSil_Click);
            // 
            // btn_urunKaydet
            // 
            this.btn_urunKaydet.Location = new System.Drawing.Point(96, 294);
            this.btn_urunKaydet.Name = "btn_urunKaydet";
            this.btn_urunKaydet.Size = new System.Drawing.Size(212, 45);
            this.btn_urunKaydet.TabIndex = 12;
            this.btn_urunKaydet.Text = "Kaydet";
            this.btn_urunKaydet.UseVisualStyleBackColor = true;
            this.btn_urunKaydet.Click += new System.EventHandler(this.btn_urunKaydet_Click);
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.Location = new System.Drawing.Point(96, 69);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(212, 26);
            this.txt_urunAd.TabIndex = 7;
            // 
            // txt_urunID
            // 
            this.txt_urunID.Location = new System.Drawing.Point(96, 25);
            this.txt_urunID.Name = "txt_urunID";
            this.txt_urunID.ReadOnly = true;
            this.txt_urunID.Size = new System.Drawing.Size(212, 26);
            this.txt_urunID.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "FİYAT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "ÜRÜN AD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID:";
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridUrunler.Location = new System.Drawing.Point(3, 3);
            this.dataGridUrunler.MultiSelect = false;
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.ReadOnly = true;
            this.dataGridUrunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridUrunler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUrunler.Size = new System.Drawing.Size(596, 672);
            this.dataGridUrunler.TabIndex = 3;
            this.dataGridUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunler_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_stokkaydet);
            this.tabPage2.Controls.Add(this.txt_stok);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lbl_urunadi);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lbl_urunid);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridStok);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "STOK";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_stokkaydet
            // 
            this.btn_stokkaydet.Location = new System.Drawing.Point(797, 107);
            this.btn_stokkaydet.Name = "btn_stokkaydet";
            this.btn_stokkaydet.Size = new System.Drawing.Size(112, 26);
            this.btn_stokkaydet.TabIndex = 7;
            this.btn_stokkaydet.Text = "Kaydet";
            this.btn_stokkaydet.UseVisualStyleBackColor = true;
            this.btn_stokkaydet.Click += new System.EventHandler(this.btn_stokkaydet_Click);
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(662, 107);
            this.txt_stok.MaxLength = 5;
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(109, 26);
            this.txt_stok.TabIndex = 6;
            this.txt_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stok_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(604, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "STOK:";
            // 
            // lbl_urunadi
            // 
            this.lbl_urunadi.AutoSize = true;
            this.lbl_urunadi.Location = new System.Drawing.Point(662, 63);
            this.lbl_urunadi.Name = "lbl_urunadi";
            this.lbl_urunadi.Size = new System.Drawing.Size(21, 20);
            this.lbl_urunadi.TabIndex = 4;
            this.lbl_urunadi.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "ÜRÜN ADI:";
            // 
            // lbl_urunid
            // 
            this.lbl_urunid.AutoSize = true;
            this.lbl_urunid.Location = new System.Drawing.Point(662, 19);
            this.lbl_urunid.Name = "lbl_urunid";
            this.lbl_urunid.Size = new System.Drawing.Size(21, 20);
            this.lbl_urunid.TabIndex = 2;
            this.lbl_urunid.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "ÜRÜN ID:";
            // 
            // dataGridStok
            // 
            this.dataGridStok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStok.Location = new System.Drawing.Point(6, 6);
            this.dataGridStok.MultiSelect = false;
            this.dataGridStok.Name = "dataGridStok";
            this.dataGridStok.ReadOnly = true;
            this.dataGridStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStok.Size = new System.Drawing.Size(545, 664);
            this.dataGridStok.TabIndex = 0;
            this.dataGridStok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStok_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_ayarlar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(937, 678);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AYARLAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ayarlar.Location = new System.Drawing.Point(281, 210);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(316, 153);
            this.btn_ayarlar.TabIndex = 0;
            this.btn_ayarlar.Text = "Bilgileri Düzenle";
            this.btn_ayarlar.UseVisualStyleBackColor = true;
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_yenipersonel);
            this.tabPage4.Controls.Add(this.chk_aktif);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.dataGridPersonel);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(937, 678);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PERSONEL";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_yenipersonel
            // 
            this.btn_yenipersonel.Location = new System.Drawing.Point(625, 80);
            this.btn_yenipersonel.Name = "btn_yenipersonel";
            this.btn_yenipersonel.Size = new System.Drawing.Size(288, 78);
            this.btn_yenipersonel.TabIndex = 0;
            this.btn_yenipersonel.Text = "Yeni Personel Ekle";
            this.btn_yenipersonel.UseVisualStyleBackColor = true;
            this.btn_yenipersonel.Click += new System.EventHandler(this.btn_yenipersonel_Click);
            // 
            // chk_aktif
            // 
            this.chk_aktif.AutoSize = true;
            this.chk_aktif.Checked = true;
            this.chk_aktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_aktif.Location = new System.Drawing.Point(625, 16);
            this.chk_aktif.Name = "chk_aktif";
            this.chk_aktif.Size = new System.Drawing.Size(143, 24);
            this.chk_aktif.TabIndex = 1;
            this.chk_aktif.Text = "Aktif Personeller";
            this.chk_aktif.UseVisualStyleBackColor = true;
            this.chk_aktif.CheckedChanged += new System.EventHandler(this.chk_aktif_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.cmb_yetki);
            this.groupBox1.Controls.Add(this.msk_tlf);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(605, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 479);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(96, 365);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(212, 45);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(96, 296);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(212, 45);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cmb_yetki
            // 
            this.cmb_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yetki.FormattingEnabled = true;
            this.cmb_yetki.Location = new System.Drawing.Point(96, 230);
            this.cmb_yetki.Name = "cmb_yetki";
            this.cmb_yetki.Size = new System.Drawing.Size(212, 28);
            this.cmb_yetki.TabIndex = 11;
            // 
            // msk_tlf
            // 
            this.msk_tlf.Location = new System.Drawing.Point(96, 148);
            this.msk_tlf.Mask = "(999) 000-0000";
            this.msk_tlf.Name = "msk_tlf";
            this.msk_tlf.ReadOnly = true;
            this.msk_tlf.Size = new System.Drawing.Size(212, 26);
            this.msk_tlf.TabIndex = 10;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(96, 189);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(212, 26);
            this.txt_email.TabIndex = 9;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(96, 107);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(212, 26);
            this.txt_soyad.TabIndex = 8;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(96, 66);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(212, 26);
            this.txt_ad.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(96, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(212, 26);
            this.txt_id.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "YETKİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-MAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dataGridPersonel
            // 
            this.dataGridPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridPersonel.Location = new System.Drawing.Point(3, 3);
            this.dataGridPersonel.MultiSelect = false;
            this.dataGridPersonel.Name = "dataGridPersonel";
            this.dataGridPersonel.ReadOnly = true;
            this.dataGridPersonel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPersonel.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersonel.Size = new System.Drawing.Size(596, 672);
            this.dataGridPersonel.TabIndex = 0;
            this.dataGridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPersonel_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(937, 678);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SİPARİŞLER";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(118, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 153);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siparişleri Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(530, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 153);
            this.button2.TabIndex = 2;
            this.button2.Text = "Raporlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 711);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_personel_FormClosed);
            this.Load += new System.EventHandler(this.frm_personel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStok)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonel)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridPersonel;
        private System.Windows.Forms.Button btn_yenipersonel;
        private System.Windows.Forms.CheckBox chk_aktif;
        private System.Windows.Forms.ComboBox cmb_yetki;
        private System.Windows.Forms.MaskedTextBox msk_tlf;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_ayarlar;
        private System.Windows.Forms.Button btn_yeniurun;
        private System.Windows.Forms.CheckBox chk_urunler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_urunSil;
        private System.Windows.Forms.Button btn_urunKaydet;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.TextBox txt_urunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.DataGridView dataGridStok;
        private System.Windows.Forms.Button btn_stokkaydet;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_urunadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_urunid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}