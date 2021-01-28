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
    public partial class frm_ayarlar : Form
    {
        public frm_ayarlar()
        {
            InitializeComponent();
        }

        Account ac = new Account();



        private void rd_kisiel_CheckedChanged(object sender, EventArgs e)
        {
            grp_kisiel.Enabled = rd_kisisel.Checked;
            grp_sifre.Enabled = rd_sifre.Checked;
        }



        private void frm_ayarlar_Load(object sender, EventArgs e)
        {
            ac = Login._hesap;
            txt_ad.Text = Login._hesap.Ad;
            txt_soyad.Text = Login._hesap.Soyad;
            txt_email.Text = Login._hesap.Email;
            msk_telefon.Text = Login._hesap.Telefon;
        }



        private void btn_kisisel_Click(object sender, EventArgs e)
        {
            if(txt_ad.Text.Trim()!="" && txt_soyad.Text.Trim()!="" && txt_email.Text.Trim()!="" && msk_telefon.Text.Length==14)
            {
                if (Account.tekrarKayitKontrol(txt_email.Text, ac.ID))
                {
                    ac.Ad = txt_ad.Text.Substring(0,1)+txt_ad.Text.Trim().Substring(1);
                    ac.Soyad = txt_soyad.Text.Substring(0, 1) + txt_soyad.Text.Trim().Substring(1);
                    ac.Email = txt_email.Text.Trim();
                    ac.Telefon = msk_telefon.Text;


                    if (ac.Duzenle(ac, "kişisel"))
                    {
                        Login._hesap = ac;
                        MessageBox.Show("Kişisel bilgileriniz güncellenmiştir...");
                        this.Close();
                    }
                    else
                        MessageBox.Show("İşlem başarısız..."); 
                }
                else
                    MessageBox.Show("Girmiş olduğunuz e-mail adresi sistemde başka bir kullanıcı tarafından kullanılmaktadır...");
            }
        }



        private void btn_sifre_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text.Trim() != "" && txt_yeni.Text.Trim() != "" && txt_tekrar.Text.Trim() != "")
            {
                if (txt_yeni.Text.Trim() == txt_tekrar.Text.Trim())
                {
                    if (ac.SifreDegistir(ac.ID, txt_sifre.Text.Trim(), txt_yeni.Text.Trim()))
                    {
                        MessageBox.Show("Şifre değiştirme işlemi gerçekleşmiştir...");
                        this.Close();
                    }
                        
                    else
                        MessageBox.Show("İşlem başarısız...");
                }
                else
                    MessageBox.Show("Şifreler arası tutarsızlık var. Lütfen kontrol ediniz...");
            }
            else
                MessageBox.Show("Lütfen ilgili alanları boş bırakmayınız...");
        }
    }
}
