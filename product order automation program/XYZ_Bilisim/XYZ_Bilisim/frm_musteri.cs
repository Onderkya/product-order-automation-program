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
    public partial class frm_musteri : Form
    {
        public frm_musteri()
        {
            InitializeComponent();
        }

        Order Siparis;
        List<Product> Sepet = new List<Product>();
        Product _urun;


        private void frm_musteri_Load(object sender, EventArgs e)
        {
            Siparis = new Order();
            lbl_kullaniciadi.Text = Login._hesap.Ad + " " + Login._hesap.Soyad;
            urunlistele();

        }

        private void urunlistele()
        {
            Baglan b = new Baglan();
            b.baglanti();
            SqlDataAdapter da = new SqlDataAdapter("select ID, URUN_ADI, FIYAT, ACIKLAMA, STOK from tbl_urunler where AKTIF=1 and STOK>0 order by URUN_ADI",b.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridUrunler.DataSource = dt;
            b.baglanti().Close();
            dataGridUrunler.Columns["ID"].Visible = false;
        }



        private void frm_musteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            frm_ayarlar fa = new frm_ayarlar();
            fa.ShowDialog();
        }

        private void dataGridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            num_adet.Value = 1;
            DataGridViewRow row = dataGridUrunler.Rows[e.RowIndex];
            _urun = new Product();
            _urun.ID = Convert.ToInt32(row.Cells["ID"].Value);
            _urun.Ad = row.Cells["URUN_ADI"].Value.ToString();
            _urun.Aciklama = row.Cells["ACIKLAMA"].Value.ToString();
            _urun.Fiyat = Convert.ToDecimal(row.Cells["FIYAT"].Value);
            _urun.Stok = Convert.ToInt16(row.Cells["STOK"].Value);

            num_adet.Maximum = _urun.Stok;

            lbl_urunadi.Text = _urun.Ad;
            rch_aciklama.Text = _urun.Aciklama;
            txt_fiyat.Text = _urun.Fiyat.ToString("C");

            txt_tutar.Text = (_urun.Fiyat * num_adet.Value).ToString("C");
        }

        private void num_adet_ValueChanged(object sender, EventArgs e)
        {
            txt_tutar.Text = (_urun.Fiyat * num_adet.Value).ToString("C");
        }

        void adetGuncelle(int _adet)
        {
            bool adt = false;

            for (int i = 0; i < Sepet.Count; i++)
            {
                if (_urun.ID == Sepet[i].ID)
                {
                    adt = true;
                    if (Sepet[i].Adet + _adet <= _urun.Stok  && Sepet[i].Adet + _adet > 0) // sıfıra düşmesin
                    {
                        Sepet[i].Adet += Convert.ToInt16(_adet);
                    }
                    else
                    {
                        if (Sepet[i].Adet + _adet > _urun.Stok)
                            MessageBox.Show("Girilen ürün miktarı stoktan fazla olduğundan sepete eklenememektedir.");
                    }
                    break;
                }
            }


            if (!adt)
            {
                _urun.Adet = Convert.ToInt16(_adet);
                Sepet.Add(_urun);
            }
            
            sepetGuncelle();
        }

        void sepetGuncelle()
        {
            if (dataGridSepet.RowCount != 0)
                dataGridSepet.Rows.Clear();


            foreach (Product item in Sepet)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridSepet.Rows[0].Clone();
                row.Cells[0].Value = item.Ad;
                row.Cells[1].Value = item.Adet.ToString();
                row.Cells[2].Value = (item.Fiyat * Convert.ToDecimal(item.Adet)).ToString();
                row.Cells[3].Value = "+";
                row.Cells[4].Value = "-";
                row.Cells[5].Value = "X";
                dataGridSepet.Rows.Add(row);

                row.Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                row.Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                row.Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btn_sepet_Click(object sender, EventArgs e)
        {
            adetGuncelle(Convert.ToInt16(num_adet.Value));

            num_adet.Value = 1;

            
        }

        private void dataGridSepet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = e.RowIndex;
            DataGridViewRow row = dataGridUrunler.Rows[satir];

            _urun.ID = Sepet[satir].ID;

            if (e.ColumnIndex == 3)
                adetGuncelle(1);
            else if (e.ColumnIndex == 4)
                adetGuncelle(-1);
            else if (e.ColumnIndex == 5)
            {
                Sepet.RemoveAt(satir);
                sepetGuncelle();
            }
            else
            {
                ///////////////////////////////////////////////////////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            Siparis.Urunler = Sepet;

            if (Siparis.Urunler.Count > 0)
            {
                /// SİPARİŞ OLUŞTURAN SORGU
                Baglan b = new Baglan();
                b.baglanti();
                SqlCommand c1 = new SqlCommand("insert into tbl_siparis (MUSTERI_ID, TARIH) values (@musteri, @tarih)", b.baglanti());
                c1.Parameters.AddWithValue("@musteri", Login._hesap.ID);
                c1.Parameters.AddWithValue("@tarih", DateTime.Now);
                c1.ExecuteNonQuery();
                b.baglanti().Close();
                ///////////////////////////


                /// OLUŞTURULAN SİPARİŞİN ID NUMARASINI ÇEKEN SORGU
                b.baglanti();
                SqlCommand c2 = new SqlCommand("select IDENT_CURRENT('tbl_siparis')", b.baglanti());
                SqlDataReader dr = c2.ExecuteReader();
                if (dr.Read())
                    Siparis.ID = Convert.ToInt16(dr[0]);
                b.baglanti().Close();
                //////////////////////////


                /// SİPARİŞİN İÇİNDEKİ KALEMLERİ DETAY TABLOSUNA İŞLEYEN SORGU
                foreach (Product item in Siparis.Urunler)
                {
                    b.baglanti();
                    SqlCommand c3 = new SqlCommand("insert into tbl_siparis_detay (SIPARIS_ID, URUN_ID, FIYAT, ADET) values (@sip_id, @urun_id, @fiyat, @adet)", b.baglanti());
                    c3.Parameters.AddWithValue("@sip_id", Siparis.ID);
                    c3.Parameters.AddWithValue("@urun_id", item.ID);
                    c3.Parameters.AddWithValue("@fiyat", item.Fiyat);
                    c3.Parameters.AddWithValue("@adet", item.Adet);
                    c3.ExecuteNonQuery();
                    b.baglanti().Close();
                }
                ///////////////////////////


                /// STOK GÜNCELLEYEN SORGU
                foreach (Product item in Siparis.Urunler)
                {
                    b.baglanti();
                    SqlCommand c4 = new SqlCommand("update tbl_urunler set STOK=STOK-@adet where ID=@urun_id", b.baglanti());
                    c4.Parameters.AddWithValue("@urun_id", item.ID);
                    c4.Parameters.AddWithValue("@adet", item.Adet);
                    c4.ExecuteNonQuery();
                    b.baglanti().Close();
                }
                //////////////////////////


                MessageBox.Show("Ödeme ekranına yönlendiriliyorsunuz...");

                frm_odeme fo = new frm_odeme(Siparis);
                fo.ShowDialog();

                urunlistele();

                dataGridSepet.Rows.Clear();

                Sepet.Clear();

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_siparisler fs = new frm_siparisler();
            fs.ShowDialog();
        }



    }
}
