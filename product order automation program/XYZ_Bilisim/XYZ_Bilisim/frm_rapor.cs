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
    public partial class frm_rapor : Form
    {
        public frm_rapor()
        {
            InitializeComponent();
        }

        Baglan b = new Baglan();

        private void frm_rapor_Load(object sender, EventArgs e)
        {
            b.baglanti();
            SqlDataAdapter da1 = new SqlDataAdapter("select URUN_ADI [ÜRÜNLER], sum(ADET) [ADET] from tbl_siparis_detay inner join tbl_urunler on tbl_siparis_detay.URUN_ID=tbl_urunler.ID group by URUN_ADI order by sum(ADET) desc", b.baglanti());
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridUrunler.DataSource = dt1;
            b.baglanti().Close();

            b.baglanti();
            SqlDataAdapter da2 = new SqlDataAdapter("select tbl_kullanicilar.ID [MÜŞTERİ NO], AD + ' ' +SOYAD [MÜŞTERİ], sum(tbl_odeme.TOPLAM_TUTAR) [TOPLAM TUTAR] from tbl_siparis inner join tbl_odeme on tbl_siparis.ID = tbl_odeme.SIPARIS_ID inner join tbl_kullanicilar on tbl_kullanicilar.ID = tbl_siparis.MUSTERI_ID group by tbl_kullanicilar.ID, AD, SOYAD order by sum(tbl_odeme.TOPLAM_TUTAR) desc", b.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridMusteri.DataSource = dt2;
            b.baglanti().Close();
        }
    }
}
