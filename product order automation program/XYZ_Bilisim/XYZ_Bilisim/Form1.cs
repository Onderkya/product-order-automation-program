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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void link_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_kayit fk = new frm_kayit(1);
            fk.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_giristipi.SelectedIndex = 0;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            if(txt_kullanici.Text.Trim()!="" && txt_sifre.Text.Trim()!="")
            {
                if (log.GirisYap(txt_kullanici.Text, txt_sifre.Text, cmb_giristipi.Text))
                {
                    MessageBox.Show("Giriş ekranına yönenlendiriliyorsunuz...");
                    this.Hide();
                    if (cmb_giristipi.SelectedIndex == 0)
                    {
                        frm_musteri fm = new frm_musteri();
                        fm.ShowDialog();
                    }                    
                    else
                    {
                        frm_personel fp = new frm_personel(cmb_giristipi.SelectedIndex + 1);
                        fp.Show();
                    }
                }
                    
                else
                    MessageBox.Show("Kullanıcı adı veya şifre geçersiz. Lütfen kontrol edip tekrar deneyiniz...");
            }
        }
    }
}
