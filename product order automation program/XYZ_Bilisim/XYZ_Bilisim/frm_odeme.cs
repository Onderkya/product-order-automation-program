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
    public partial class frm_odeme : Form
    {
        public frm_odeme(Order _siparis)
        {
            InitializeComponent();
            siparis = _siparis;
        }

        Order siparis = new Order();
        decimal toplamTutar;



        private void frm_odeme_Load(object sender, EventArgs e)
        {
            cmb_taksit.SelectedIndex = 0;

            lbl_tutar.Text = toplamTutar.ToString("C");

            datetimeSonKull.MinDate = DateTime.Now;
            
        }



        private void txt_kartsahibi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }



        private bool Odeme_authentication()
        {
            // BANKADAN ÖDEME ONAYI DÖNDÜREN METOT
            Baglan b = new Baglan();
            b.baglanti();
            SqlCommand c1 = new SqlCommand("insert into tbl_odeme (SIPARIS_ID, TOPLAM_TUTAR, TAKSIT) values (@siparis, @tutar, @taksit)", b.baglanti());
            c1.Parameters.AddWithValue("@siparis", siparis.ID);
            c1.Parameters.AddWithValue("@tutar", toplamTutar);
            c1.Parameters.AddWithValue("@taksit", Convert.ToInt16(cmb_taksit.SelectedItem));
            c1.ExecuteNonQuery();
            b.baglanti().Close();

            return true;            
        }


        private void taksitlendir()
        {
            toplamTutar = 0;
            foreach (Product item in siparis.Urunler)
            {
                toplamTutar += (item.Fiyat * item.Adet);
            }

            
            int taksit = Convert.ToInt16(cmb_taksit.SelectedItem);
            decimal vadefarki = (((decimal)Math.Pow(taksit - 1, 2) / 333) * toplamTutar);
            //decimal vadefarki = (((taksit - 1)*(taksit-1)) / 333) * toplamTutar;
            toplamTutar +=vadefarki;

            
            //if(Convert.ToInt16(cmb_taksit.SelectedItem) != 1)
            //    vadefarki = (toplamTutar / 100) * Convert.ToDecimal(cmb_taksit.SelectedItem);


            lbl_tutar.Text = toplamTutar.ToString("C");
        }
        

        private void btn_odeme_yap_Click(object sender, EventArgs e)
        {
            if (txt_kartsahibi.Text != "" && msk_ccv.Text.Length == 3 && msk_kart1.Text.Length == 4 && msk_kart2.Text.Length == 4 && msk_kart3.Text.Length == 4 && msk_kart4.Text.Length == 4)
            {
                if (Odeme_authentication())
                {
                    MessageBox.Show("Ödeme işleminiz için teşekkürler... \n\nSiparişiniz en kısa sürede kargoya verilecektir...");
                    this.Close();
                }
                    
                else
                    MessageBox.Show("Ödeme işlemi gerçekleşemedi...");
            }
        }



        private void cmb_taksit_SelectedIndexChanged(object sender, EventArgs e)
        {
            taksitlendir();
        }


        private void msk_kart1_TextChanged(object sender, EventArgs e)
        {
            if (msk_kart1.Text.Length == 4)
                msk_kart2.Focus();
        }


        private void msk_kart2_TextChanged(object sender, EventArgs e)
        {
            if (msk_kart2.Text.Length == 4)
                msk_kart3.Focus();
        }


        private void msk_kart3_TextChanged(object sender, EventArgs e)
        {
            if (msk_kart3.Text.Length == 4)
                msk_kart4.Focus();
        }


        private void msk_kart4_TextChanged(object sender, EventArgs e)
        {
            if (msk_kart4.Text.Length == 4)
                msk_ccv.Focus();
        }
        

    }
}
