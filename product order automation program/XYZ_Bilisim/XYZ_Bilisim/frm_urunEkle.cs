using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Bilisim
{
    public partial class frm_urunEkle : Form
    {

        public frm_urunEkle()
        {
            InitializeComponent();
        }



        private void btn_urunKaydet_Click(object sender, EventArgs e)
        {
            if (Bos_alan_kontrolu())
            {
                if (Product.tekrarKayitKontrol(txt_urunAd.Text.Trim()))
                    {
                        try
                        {
                            Product pd = new Product();
                            pd.Ad = txt_urunAd.Text.Substring(0, 1).ToUpper() + txt_urunAd.Text.Substring(1).Trim().ToLower();
                            pd.Fiyat = Convert.ToDecimal(txt_Fiyat.Text.Trim());
                            pd.Aciklama = txt_aciklama.Text.Substring(0, 1).ToUpper() + txt_aciklama.Text.Substring(1).Trim().ToLower();
                            pd.Aktif = true;
                            pd.UrunEkle(pd);
                            MessageBox.Show("Yeni ürün sisteme eklendi...");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Kayıt işlemi başarısız...");
                        }
                    }
                    else
                        MessageBox.Show("Belirtilen ürün sistemde zaten kayıtlıdır. Lütfen kontrol edip tekrar deneyiniz...");
            }
        }


        private bool Bos_alan_kontrolu()
        {
            bool onay = false;
            if (txt_urunAd.Text.Trim() != "" && txt_Fiyat.Text.Trim() != "" && txt_aciklama.Text.Trim() != "")
            {
                onay = true;
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!...");
                if (txt_urunAd.Text == "")
                    txt_urunAd.Focus();
                else if (txt_Fiyat.Text == "")
                    txt_Fiyat.Focus();
                else if (txt_aciklama.Text == "")
                    txt_aciklama.Focus();
                else
                    onay = false;
            }
            return onay;
        }


    }
}
