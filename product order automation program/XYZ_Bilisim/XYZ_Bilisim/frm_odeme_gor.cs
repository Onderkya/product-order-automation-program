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
    public partial class frm_odeme_gor : Form
    {
        int SiparisID;

        public frm_odeme_gor(int _siparisID)
        {
            InitializeComponent();
            SiparisID = _siparisID;
        }

        private void frm_odeme_gor_Load(object sender, EventArgs e)
        {
            Baglan b = new Baglan();
            b.baglanti();
            SqlCommand c1 = new SqlCommand("select * from tbl_odeme where SIPARIS_ID = @id", b.baglanti());
            c1.Parameters.AddWithValue("@id", SiparisID);
            SqlDataReader dr = c1.ExecuteReader();
            decimal odenen = 0;
            if (dr.Read())
            {
                txt_taksit.Text = dr["TAKSIT"].ToString();
                odenen = Convert.ToDecimal(dr["TOPLAM_TUTAR"]);
                txt_odenen.Text = odenen.ToString("C");
            }
            b.baglanti().Close();

            SqlCommand c2 = new SqlCommand("select * from tbl_siparis_detay where SIPARIS_ID = @id", b.baglanti());
            c2.Parameters.AddWithValue("@id", SiparisID);
            SqlDataReader dr2 = c2.ExecuteReader();
            decimal tutar = 0;
            while (dr2.Read())
            {
                tutar += Convert.ToInt16(dr2["ADET"]) * Convert.ToDecimal(dr2["FIYAT"]);
            }
            txt_tutar.Text = tutar.ToString("C");
            b.baglanti().Close();
            btn_kapat.Focus();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
