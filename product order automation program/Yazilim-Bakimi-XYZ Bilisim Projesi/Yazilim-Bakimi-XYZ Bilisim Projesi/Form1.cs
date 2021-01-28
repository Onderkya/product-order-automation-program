using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Yazilim_Bakimi_XYZ_Bilisim_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yetki = 999;
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            

            
                if (!String.IsNullOrEmpty(txt_Email.Text)&& !String.IsNullOrEmpty(txt_Sifre.Text))
                {

                RegisterandLogin giris = new RegisterandLogin();
                bool kontrol= giris.Giris(txt_Email.Text, txt_Sifre.Text);
                yetki = giris.yetki;
                if (kontrol)
                {
                    yetki = giris.yetki;
                    MessageBox.Show("Tebrikler Giriş Yapıldı Yönlendirileceksiniz..");
                    if (yetki == 0)
                    {
                        frm_musteri muster = new frm_musteri();
                        muster.ShowDialog();
                    }
                    else
                    {
                        frm_personel fp = new frm_personel();
                        fp.yetki = this.yetki;
                        fp.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Hata");
                }

                    

                }
                else
                {
                    MessageBox.Show("Lütfen Email ve Şifreyi Giriniz..");
                }

            
            


        }

        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.ShowDialog();

          
            //    if (!String.IsNullOrEmpty(txt_Email.Text) && !String.IsNullOrEmpty(txt_Sifre.Text))
            //    {

            //    bool email_Kontrol= emailkontrol(txt_Email.Text);
            //    if (email_Kontrol)
            //    {

            //        RegisterandLogin yenikayıt = new RegisterandLogin();
            //        bool kontrol = yenikayıt.Kayit(txt_Email.Text, txt_Sifre.Text);
            //        if (kontrol)
            //        {
            //            MessageBox.Show("Kayıt Başarılı");

            //        }
            //        else MessageBox.Show("Kayıt Başarısız");


            //    }
            //    else
            //    {
            //        MessageBox.Show("Geçerli Bir email adresini giriniz..");
            //    }


            //}
            //    else
            //    {
            //        MessageBox.Show("Lütfen Email ve Şifreyi Giriniz..");
            //    }
           
        }

      

        /*
         * bool IsValidEmail(string email)

 {​​​​

     try {​​​​

         var addr = new System.Net.Mail.MailAddress(email);

         return addr.Address == email;

     }​​​​

     catch {​​​​

         return false;

     }​​​​

 }​​​​
         * 
         * 
         */

    }
}
