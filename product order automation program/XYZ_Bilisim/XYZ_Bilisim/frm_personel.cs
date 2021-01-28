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
    public partial class frm_personel : Form
    {
        public frm_personel()
        {
            InitializeComponent();
        }



        private int yetki;




        public frm_personel(int _yetki)
        {
            this.yetki = _yetki;
            InitializeComponent();
        }



        private void btn_yenipersonel_Click(object sender, EventArgs e)
        {
            frm_kayit fk = new frm_kayit(2);
            fk.ShowDialog();
            PersonelListele();

        }



        private void frm_personel_Load(object sender, EventArgs e)
        {
            if(yetki == 2)
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
            else
            {
                PersonelListele();
                ComboYetki();
            }

            UrunListele();
            StokListele();



        }



        private void StokListele()
        {
            Baglan b = new Baglan();
            b.baglanti();
            SqlDataAdapter da = new SqlDataAdapter("select ID, URUN_ADI, STOK from tbl_urunler where AKTIF=1 order by URUN_ADI", b.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridStok.DataSource = dt;
            b.baglanti().Close();
        }



        void PersonelListele()
        {
            Baglan b = new Baglan();
            b.baglanti();
            SqlDataAdapter da = new SqlDataAdapter("select tbl_kullanicilar.ID,AD,SOYAD,TELEFON,EMAIL,YETKI_ADI from tbl_kullanicilar inner join tbl_yetki on tbl_yetki.ID=tbl_kullanicilar.YETKI_TIPI where YETKI_TIPI!=1 and AKTIF=@p2", b.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p2", chk_aktif.Checked);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridPersonel.DataSource = dt;
            b.baglanti().Close();
        }


        
        void ComboYetki()
        {
            Baglan b = new Baglan();
            b.baglanti();
            SqlCommand cmd = new SqlCommand("select * from tbl_yetki order by ID", b.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_yetki.Items.Add(dr[1].ToString());
            }
            b.baglanti().Close();
        }



        private void chk_aktif_CheckedChanged(object sender, EventArgs e)
        {
            PersonelListele();
        }



        private void dataGridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridPersonel.Rows[e.RowIndex];
            txt_id.Text = row.Cells["ID"].Value.ToString();
            txt_ad.Text = row.Cells["AD"].Value.ToString();
            txt_soyad.Text = row.Cells["SOYAD"].Value.ToString();
            txt_email.Text = row.Cells["EMAIL"].Value.ToString();
            msk_tlf.Text = row.Cells["TELEFON"].Value.ToString();
            cmb_yetki.SelectedItem = row.Cells["YETKI_ADI"].Value.ToString();
        }



        void Guncelleme(string islem)
        {
            Account ac = new Account();
            ac.ID = Convert.ToInt16(txt_id.Text);
            ac.Ad = txt_ad.Text;
            ac.Soyad = txt_soyad.Text;
            ac.Email = txt_email.Text;
            ac.Telefon = msk_tlf.Text;
            ac.Yetki = cmb_yetki.SelectedIndex + 1;

            if(islem=="güncelle")
            {
                if (ac.Duzenle(ac))
                {
                    MessageBox.Show("Güncelleme işlemi başarılı...");
                    PersonelListele();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız...");
                }
            }
            else // sil
            {
                if (ac.Sil(ac.ID))
                {
                    MessageBox.Show("Silme işlemi başarılı...");
                    PersonelListele();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız...");
                }
            }
            
            txt_id.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_email.Text = "";
            msk_tlf.Text = "";
            cmb_yetki.SelectedIndex = 0;
        }



        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Guncelleme("güncelle");                
        }



        private void btn_sil_Click(object sender, EventArgs e)
        {
            Guncelleme("sil");            
        }


        
        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            frm_ayarlar fa = new frm_ayarlar();
            fa.ShowDialog();
        }



        private void frm_personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void btn_yeniurun_Click(object sender, EventArgs e)
        {
            frm_urunEkle fue = new frm_urunEkle();
            fue.ShowDialog();
            UrunListele();
        }



        void UrunListele()
        {
            Baglan b = new Baglan();
            b.baglanti();
            SqlDataAdapter da = new SqlDataAdapter("select ID, URUN_ADI, FIYAT, ACIKLAMA, AKTIF from tbl_urunler where AKTIF=@aktif order by URUN_ADI", b.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@aktif", chk_urunler.Checked);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridUrunler.DataSource = dt;
            b.baglanti().Close();
            StokListele();
        }



        private void chk_urunler_CheckedChanged(object sender, EventArgs e)
        {
            UrunListele();
        }



        private void dataGridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridUrunler.Rows[e.RowIndex];
            txt_urunID.Text = row.Cells["ID"].Value.ToString();
            txt_urunAd.Text = row.Cells["URUN_ADI"].Value.ToString();
            txt_Fiyat.Text = row.Cells["FIYAT"].Value.ToString();
            txt_aciklama.Text = row.Cells["ACIKLAMA"].Value.ToString();
            chk_urunler.Checked = Convert.ToBoolean(row.Cells["AKTIF"].Value);
        }



        private void btn_urunKaydet_Click(object sender, EventArgs e)
        {
            UrunGuncelleme("güncelle");
        }

        

        private void btn_urunSil_Click(object sender, EventArgs e)
        {
            UrunGuncelleme("sil");
        }



        void UrunGuncelleme(string islem)
        {
            if(txt_urunID.Text != "")
            {
                Product pd = new Product();
                pd.ID = Convert.ToInt16(txt_urunID.Text);
                pd.Ad = txt_urunAd.Text;
                pd.Fiyat = Convert.ToDecimal(txt_Fiyat.Text);
                pd.Aciklama = txt_aciklama.Text;

                if (islem == "güncelle")
                {
                    if (pd.Duzenle(pd))
                    {
                        MessageBox.Show("Güncelleme işlemi başarılı...");
                        UrunListele();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız...");
                    }
                }
                else // sil
                {
                    if (pd.Sil(pd.ID))
                    {
                        MessageBox.Show("Silme işlemi başarılı...");
                        UrunListele();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız...");
                    }
                }

                txt_urunID.Text = "";
                txt_urunAd.Text = "";
                txt_Fiyat.Text = "";
                txt_aciklama.Text = "";
            }
        }

        private void dataGridStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridStok.Rows[e.RowIndex];
            lbl_urunid.Text = row.Cells["ID"].Value.ToString();
            lbl_urunadi.Text = row.Cells["URUN_ADI"].Value.ToString();
            txt_stok.Text = row.Cells["STOK"].Value.ToString();
        }

        private void txt_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void btn_stokkaydet_Click(object sender, EventArgs e)
        {
            if(lbl_urunid.Text!="...")
            {
                Baglan b = new Baglan();
                b.baglanti();
                SqlCommand cmd= new SqlCommand("update tbl_urunler set STOK=@stok where ID=@id",b.baglanti());
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt16(txt_stok.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt16(lbl_urunid.Text));
                cmd.ExecuteNonQuery();
                b.baglanti().Close();
                MessageBox.Show("Ürüne ait stok bilgisi güncellendi...");
                lbl_urunid.Text = "...";
                lbl_urunadi.Text = "...";
                txt_stok.Text = "";
                StokListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_siparisler fs = new frm_siparisler();
            fs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_rapor fr = new frm_rapor();
            fr.Show();
        }



        



    }
}
