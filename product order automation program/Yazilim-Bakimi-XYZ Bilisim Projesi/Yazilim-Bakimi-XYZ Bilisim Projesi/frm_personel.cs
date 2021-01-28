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
namespace Yazilim_Bakimi_XYZ_Bilisim_Projesi
{
    public partial class frm_personel : Form
    {
        public frm_personel()
        {
            InitializeComponent();
        }

        public int yetki;

        private void frm_personel_Load(object sender, EventArgs e)
        {
            if (yetki == 1)
                tabControl1.TabPages.RemoveAt(3);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
          
            RegisterandLogin rgs = new RegisterandLogin();
            rgs.yetki = 2;
            Accounts ac = new Accounts();
            if (String.IsNullOrEmpty(txt_ID.Text))
            {
                ac.ID = 0;
            }
            else
            {
                ac.ID = Convert.ToInt32(txt_ID.Text);

            }
            
            ac.AD = txt_Adi.Text;
            ac.SOYAD = txt_Soyad.Text;
            ac.TELEFON = txt_Telefon.Text;
            ///ac.SIFRE = txt_Sifre.Text;
            ac.EMAIL = txt_Email.Text;
            ac.YETKI = cmb_Yetki.SelectedIndex;

            bool formkontrol = true;
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    if (String.IsNullOrEmpty(t.Text))
                    {
                        formkontrol = false;
                        break;
                       
                    }
                   
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mk = (MaskedTextBox)item;
                    if (String.IsNullOrEmpty(mk.Text))
                    {
                        formkontrol = false;
                        break;
                    }

                }

            }

            if (cmb_Yetki.SelectedItem!=null)
            {
                formkontrol = true;
            }

            if (formkontrol)
            {




                if (ac.ID > 0)
                {

                    if (rgs.Guncelleme(ac))
                    {
                        MessageBox.Show("Güncelleme işlemi Başarılı");
                        foreach (var item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                TextBox t = (TextBox)item;
                                t.Enabled = true;
                                t.Text = "";
                            }

                        }
                        txt_Telefon.Enabled = true;
                        txt_Telefon.Text = "";
                    }
                    else MessageBox.Show("Güncelleme Yapılamadı");

                }



                else
                {
                    if (rgs.YeniKayit(ac, txt_Sifre.Text))
                    {
                        MessageBox.Show("Kayıt başarılı");
                        foreach (var item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                TextBox t = (TextBox)item;
                                t.Enabled = true;
                                t.Text = "";
                            }

                        }
                        txt_Telefon.Enabled = true;
                        txt_Telefon.Text = "";
                    }
                    else MessageBox.Show("Kayıt Başarısız");



                }
                PersonelListele();
            }
            else MessageBox.Show("Lütfen Tüm Alanları Doldurun");

        }


        void PersonelListele()
        {

            Baglan bag = new Baglan();
   

            SqlDataAdapter s = new SqlDataAdapter("select ID,AD,SOYAD,EMAIL,TELEFON,YETKI from tbl_kullanicilar where YETKI>=1 and AKTIF=@P1", bag.Baglanti());
            s.SelectCommand.Parameters.AddWithValue("@p1", checkBox1.Checked);
             DataTable dt = new DataTable();
            s.Fill(dt);
            data_Personeller.DataSource = dt;
            bag.Baglanti().Close();
            


        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab==tabPage4)
            {
                PersonelListele();
            }
        }

        private void data_Personeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            DataGridViewRow row = this.data_Personeller.Rows[e.RowIndex];
            txt_ID.Text = row.Cells["ID"].Value.ToString();
            txt_Adi.Text = row.Cells["AD"].Value.ToString();
            txt_Soyad.Text = row.Cells["SOYAD"].Value.ToString();
            txt_Telefon.Text = row.Cells["TELEFON"].Value.ToString();
            txt_Email.Text = row.Cells["EMAIL"].Value.ToString();
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Enabled = false;
                }
                
            }
            txt_Telefon.Enabled = false;
            cmb_Yetki.SelectedIndex =Convert.ToInt32(row.Cells["YETKI"].Value);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_Adi.Text))
            {
                RegisterandLogin rgs = new RegisterandLogin();
                rgs.Kullanici_Sil(Convert.ToInt32(txt_ID.Text));
                MessageBox.Show("Kullanıcı Silinmiştir Artık Sisteme Giriş Yapamayacaktır..\n Tekrar Aktif Etmek İçin Yetkisini Değiştirin ");
                PersonelListele();
            }
            else MessageBox.Show("Kullanıcı Bilgileri Yüklenmeden Silme Yapılamaz\n Lütfen Bir Kullanıcı Seçiniz");
           

        }
    }
}
