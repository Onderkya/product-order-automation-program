using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazilim_Bakimi_XYZ_Bilisim_Projesi
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        bool emailkontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;

            }
            catch
            {

                return false;
            }




        }

        private void btn_kaydet_Click(object sender, EventArgs e)

        {
            bool telefonkontrol = false;

            bool kontroltext = false;
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;

                    if (!String.IsNullOrEmpty(t.Text))
                    {
                        kontroltext = true;
                    }
                    else
                    {
                        kontroltext = false;
                        t.Focus();

                        break;
                    }

                }

                else if (item is MaskedTextBox) 
                {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)item;

                    if (maskedTextBox.Text.Length==14)
                    {
                        kontroltext = true;
                    }
                    else
                    {
                        kontroltext = false;
                        telefonkontrol = true;
                       
                        maskedTextBox.Focus();
                        break;
                    }

                
                
                }
               
               
                

            }


            if (kontroltext)
            {

                bool email_Kontrol = emailkontrol(txt_Email.Text);
                if (email_Kontrol)
                {

                    RegisterandLogin yenikayıt = new RegisterandLogin();
                    Accounts ac = new Accounts();
                    ac.AD = txt_Adi.Text;
                    ac.SOYAD = txt_Soyad.Text;
                    ac.TELEFON = txt_Telefon.Text;
                    ac.EMAIL = txt_Email.Text;
                   // ac.SIFRE = txt_Sifre.Text;

                    bool kontrol = yenikayıt.YeniKayit(ac,txt_Sifre.Text);
                    if (kontrol)
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        this.Close();
                    }
                    else MessageBox.Show("Böyle bir kayıt zaten var");


                }
                else
                {
                    MessageBox.Show("Geçerli Bir email adresini giriniz..");
                }


            }
            else
            {
                if (telefonkontrol)
                {
                    MessageBox.Show("Geçerli Bir Telefon Numarası Giriniz..");
                }
                else
                {
                    MessageBox.Show("Lütfen Email ve Şifreyi Giriniz..");
                }
            }
        }
    }
}
