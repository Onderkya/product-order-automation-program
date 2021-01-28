using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace XYZ_Bilisim
{
    public partial class frm_kayit : Form
    {
        private int yetki;



        public frm_kayit()
        {
            InitializeComponent();
        }



        public frm_kayit(int _yetki)
        {
            this.yetki = _yetki;
            InitializeComponent();
        }

        


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (Bos_alan_kontrolu())
            {
                if (Email_Kontrol(txt_email.Text))
                {                    
                    if (Account.tekrarKayitKontrol(txt_email.Text.Trim()))
                    {
                        try
                        {
                            Account ac = new Account();
                            ac.Ad = txt_ad.Text.Substring(0, 1).ToUpper() + txt_ad.Text.Substring(1).Trim().ToLower();
                            ac.Soyad = txt_soyad.Text.Substring(0, 1).ToUpper() + txt_soyad.Text.Substring(1).Trim().ToLower();
                            ac.Telefon = msk_telefon.Text.Trim();
                            ac.Email = txt_email.Text.Trim();
                            ac.Yetki = this.yetki;
                            ac.Aktif = true;
                            ac.Sifre = txt_sifre.Text.Trim();
                            ac.KayitOl(ac);
                            MessageBox.Show("Kayıt işlemi başarılı. Sisteme E-mail ve Şifreniz ile giriş yapabilirsiniz...");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Kayıt işlemi başarısız...");
                        }
                    }
                    else
                        MessageBox.Show("Belirtilen E-Mail adresi sistemde zaten kayıtlıdır. Lütfen kontrol edip tekrar deneyiniz...");
                    
                }
            }
        }



        private bool Bos_alan_kontrolu()
        {
            bool onay = false;
            if (txt_ad.Text.Trim() != "" && txt_soyad.Text.Trim() != "" && txt_email.Text.Trim() != "" && txt_sifre.Text.Trim() != "" && msk_telefon.Text.Length == 14)
            {
                onay = true;
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!...");
                if (txt_ad.Text == "")
                    txt_ad.Focus();
                else if (txt_soyad.Text == "")
                    txt_soyad.Focus();
                else if (txt_email.Text == "")
                    txt_email.Focus();
                else if (txt_sifre.Text == "")
                    txt_sifre.Focus();
                else if (msk_telefon.Text.Length < 14)
                    msk_telefon.Focus();
                else
                    onay = false;
            }
            return onay;
        }



        private bool Email_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                MessageBox.Show("Geçerli bir E-Mail adresi giriniz...");
                return false;
            }
        }
    }
}
