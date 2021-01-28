namespace XYZ_Bilisim
{
    partial class frm_odeme
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
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_kart1 = new System.Windows.Forms.MaskedTextBox();
            this.msk_kart2 = new System.Windows.Forms.MaskedTextBox();
            this.msk_kart3 = new System.Windows.Forms.MaskedTextBox();
            this.msk_kart4 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimeSonKull = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kartsahibi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_ccv = new System.Windows.Forms.MaskedTextBox();
            this.btn_odeme_yap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_taksit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOPLAM TUTAR:";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.ForeColor = System.Drawing.Color.Red;
            this.lbl_tutar.Location = new System.Drawing.Point(320, 55);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(47, 37);
            this.lbl_tutar.TabIndex = 1;
            this.lbl_tutar.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kart No:";
            // 
            // msk_kart1
            // 
            this.msk_kart1.Location = new System.Drawing.Point(121, 201);
            this.msk_kart1.Mask = "0000";
            this.msk_kart1.Name = "msk_kart1";
            this.msk_kart1.Size = new System.Drawing.Size(43, 26);
            this.msk_kart1.TabIndex = 1;
            this.msk_kart1.TextChanged += new System.EventHandler(this.msk_kart1_TextChanged);
            // 
            // msk_kart2
            // 
            this.msk_kart2.Location = new System.Drawing.Point(174, 201);
            this.msk_kart2.Mask = "0000";
            this.msk_kart2.Name = "msk_kart2";
            this.msk_kart2.Size = new System.Drawing.Size(43, 26);
            this.msk_kart2.TabIndex = 2;
            this.msk_kart2.TextChanged += new System.EventHandler(this.msk_kart2_TextChanged);
            // 
            // msk_kart3
            // 
            this.msk_kart3.Location = new System.Drawing.Point(227, 201);
            this.msk_kart3.Mask = "0000";
            this.msk_kart3.Name = "msk_kart3";
            this.msk_kart3.Size = new System.Drawing.Size(43, 26);
            this.msk_kart3.TabIndex = 3;
            this.msk_kart3.TextChanged += new System.EventHandler(this.msk_kart3_TextChanged);
            // 
            // msk_kart4
            // 
            this.msk_kart4.Location = new System.Drawing.Point(280, 201);
            this.msk_kart4.Mask = "0000";
            this.msk_kart4.Name = "msk_kart4";
            this.msk_kart4.Size = new System.Drawing.Size(43, 26);
            this.msk_kart4.TabIndex = 4;
            this.msk_kart4.TextChanged += new System.EventHandler(this.msk_kart4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Son Kull.:";
            // 
            // datetimeSonKull
            // 
            this.datetimeSonKull.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSonKull.Location = new System.Drawing.Point(121, 248);
            this.datetimeSonKull.Name = "datetimeSonKull";
            this.datetimeSonKull.Size = new System.Drawing.Size(110, 26);
            this.datetimeSonKull.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kart Sahibi:";
            // 
            // txt_kartsahibi
            // 
            this.txt_kartsahibi.Location = new System.Drawing.Point(121, 151);
            this.txt_kartsahibi.MaxLength = 250;
            this.txt_kartsahibi.Name = "txt_kartsahibi";
            this.txt_kartsahibi.Size = new System.Drawing.Size(347, 26);
            this.txt_kartsahibi.TabIndex = 0;
            this.txt_kartsahibi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kartsahibi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "CCV:";
            // 
            // msk_ccv
            // 
            this.msk_ccv.Location = new System.Drawing.Point(343, 248);
            this.msk_ccv.Mask = "000";
            this.msk_ccv.Name = "msk_ccv";
            this.msk_ccv.Size = new System.Drawing.Size(37, 26);
            this.msk_ccv.TabIndex = 6;
            // 
            // btn_odeme_yap
            // 
            this.btn_odeme_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_odeme_yap.Location = new System.Drawing.Point(268, 369);
            this.btn_odeme_yap.Name = "btn_odeme_yap";
            this.btn_odeme_yap.Size = new System.Drawing.Size(200, 58);
            this.btn_odeme_yap.TabIndex = 8;
            this.btn_odeme_yap.Text = "ÖDEME YAP";
            this.btn_odeme_yap.UseVisualStyleBackColor = true;
            this.btn_odeme_yap.Click += new System.EventHandler(this.btn_odeme_yap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Taksit:";
            // 
            // cmb_taksit
            // 
            this.cmb_taksit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_taksit.FormattingEnabled = true;
            this.cmb_taksit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "9",
            "12"});
            this.cmb_taksit.Location = new System.Drawing.Point(121, 304);
            this.cmb_taksit.Name = "cmb_taksit";
            this.cmb_taksit.Size = new System.Drawing.Size(110, 28);
            this.cmb_taksit.TabIndex = 7;
            this.cmb_taksit.SelectedIndexChanged += new System.EventHandler(this.cmb_taksit_SelectedIndexChanged);
            // 
            // frm_odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 447);
            this.Controls.Add(this.cmb_taksit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_odeme_yap);
            this.Controls.Add(this.msk_ccv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_kartsahibi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetimeSonKull);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msk_kart4);
            this.Controls.Add(this.msk_kart3);
            this.Controls.Add(this.msk_kart2);
            this.Controls.Add(this.msk_kart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_odeme";
            this.Load += new System.EventHandler(this.frm_odeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_kart1;
        private System.Windows.Forms.MaskedTextBox msk_kart2;
        private System.Windows.Forms.MaskedTextBox msk_kart3;
        private System.Windows.Forms.MaskedTextBox msk_kart4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimeSonKull;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kartsahibi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_ccv;
        private System.Windows.Forms.Button btn_odeme_yap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_taksit;
    }
}