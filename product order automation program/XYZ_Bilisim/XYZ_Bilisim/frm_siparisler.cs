using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XYZ_Bilisim
{
    public partial class frm_siparisler : Form
    {
        public frm_siparisler()
        {
            InitializeComponent();
        }

        Baglan b = new Baglan();
        int siparisNo;

        private void frm_siparisler_Load(object sender, EventArgs e)
        {
            b.baglanti();
            string sorgu = "";
            if (Login._hesap.Yetki == 1)
                sorgu = "select tbl_siparis.ID [SİPARİŞ NO], MUSTERI_ID [MÜŞTERİ NO], TARIH [TARİH], TOPLAM_TUTAR [TOPLAM TUTAR] from tbl_siparis full join tbl_odeme on tbl_siparis.ID=tbl_odeme.SIPARIS_ID where MUSTERI_ID = @id";
            else
                sorgu = "select tbl_siparis.ID [SİPARİŞ NO], MUSTERI_ID [MÜŞTERİ NO], TARIH [TARİH], TOPLAM_TUTAR [TOPLAM TUTAR] from tbl_siparis full join tbl_odeme on tbl_siparis.ID=tbl_odeme.SIPARIS_ID";
            SqlDataAdapter da1 = new SqlDataAdapter(sorgu, b.baglanti());
            da1.SelectCommand.Parameters.AddWithValue("@id", Login._hesap.ID);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridSiparis.DataSource = dt1;
            b.baglanti().Close();

        }

        private void dataGridSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            b.baglanti();

            if (dataGridSiparis.Rows[dataGridSiparis.CurrentRow.Index].Cells[0].Value.ToString() != "")
            {
                siparisNo = Convert.ToInt16(dataGridSiparis.Rows[dataGridSiparis.CurrentRow.Index].Cells[0].Value);
                SqlDataAdapter da2 = new SqlDataAdapter("select URUN_ADI, ADET, tbl_siparis_detay.FIYAT * ADET [TUTAR] from tbl_siparis_detay inner join tbl_urunler on tbl_siparis_detay.URUN_ID=tbl_urunler.ID where SIPARIS_ID=@sipId", b.baglanti());
                da2.SelectCommand.Parameters.AddWithValue("@sipId", siparisNo);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridDetay.DataSource = dt2;
            }

            b.baglanti().Close();
        }

        private void öDEMEDETAYINIGÖRÜNTÜLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_odeme_gor fog = new frm_odeme_gor(siparisNo);
            fog.ShowDialog();
        }
    }
}
