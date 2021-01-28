namespace XYZ_Bilisim
{
    partial class frm_siparisler
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridSiparis = new System.Windows.Forms.DataGridView();
            this.dataGridDetay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetay)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 82);
            this.panel1.TabIndex = 0;
            // 
            // dataGridSiparis
            // 
            this.dataGridSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparis.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridSiparis.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridSiparis.Location = new System.Drawing.Point(0, 82);
            this.dataGridSiparis.MultiSelect = false;
            this.dataGridSiparis.Name = "dataGridSiparis";
            this.dataGridSiparis.ReadOnly = true;
            this.dataGridSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSiparis.Size = new System.Drawing.Size(639, 717);
            this.dataGridSiparis.TabIndex = 1;
            this.dataGridSiparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSiparis_CellClick);
            // 
            // dataGridDetay
            // 
            this.dataGridDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDetay.Location = new System.Drawing.Point(639, 82);
            this.dataGridDetay.MultiSelect = false;
            this.dataGridDetay.Name = "dataGridDetay";
            this.dataGridDetay.ReadOnly = true;
            this.dataGridDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetay.Size = new System.Drawing.Size(649, 717);
            this.dataGridDetay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(222, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(853, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "SİPARİŞ DETAYI";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 48);
            // 
            // öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem
            // 
            this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem.Name = "öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem";
            this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem.Text = "ÖDEME DETAYINI GÖRÜNTÜLE";
            this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem.Click += new System.EventHandler(this.öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem_Click);
            // 
            // frm_siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 799);
            this.Controls.Add(this.dataGridDetay);
            this.Controls.Add(this.dataGridSiparis);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_siparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_siparisler";
            this.Load += new System.EventHandler(this.frm_siparisler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetay)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridSiparis;
        private System.Windows.Forms.DataGridView dataGridDetay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem;
    }
}