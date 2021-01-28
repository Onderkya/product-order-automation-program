using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Yazilim_Bakimi_XYZ_Bilisim_Projesi
{
    public class RegisterandLogin
    {
       public  int yetki = 0;
        Baglan bag;

        public RegisterandLogin()
        {
             bag = new Baglan();
        }
        public bool Giris(string email,string sifre)
        {
           
            string _sifre = sifrele(sifre);
            bool onay = false;
            

            bag.Baglanti();

            SqlCommand s = new SqlCommand("select * from tbl_kullanicilar where EMAIL=@p1 and SIFRE=@p2 and AKTIF=1", bag.Baglanti());
            s.Parameters.AddWithValue("p1", email);
            s.Parameters.AddWithValue("p2", _sifre);
            SqlDataReader dr = s.ExecuteReader();
            if (dr.Read())
            {
                yetki = Convert.ToInt32(dr["YETKI"]);
                onay = true;
            }
            bag.Baglanti().Close();

            return onay;

        }
        public bool YeniKayit(Accounts hesap,string sifre)
        {
            string _ad = hesap.AD.Substring(0, 1).ToUpper() + hesap.AD.Substring(1).ToLower();
            string _soyad = hesap.SOYAD.Substring(0, 1).ToUpper() + hesap.SOYAD.Substring(1).ToLower();
            string _sifre= sifrele(sifre);

            bool kontrol = false;
            try
            {                                
                if (TekrarKayitKontrol(hesap.EMAIL))
                {
                    bag.Baglanti();
                    string sorgu = "";
                    if (this.yetki == 2)
                    {
                        sorgu = " INSERT into tbl_kullanicilar (AD,SOYAD,TELEFON,EMAIL,SIFRE,YETKI) values (@p1,@p2,@p3,@p4,@p5,@p6)";

                    }
                    else
                    {
                        sorgu = " INSERT into tbl_kullanicilar (AD,SOYAD,TELEFON,EMAIL,SIFRE) values (@p1,@p2,@p3,@p4,@p5)";

                    }
                    SqlCommand s = new SqlCommand(sorgu, bag.Baglanti());
                    s.Parameters.AddWithValue("p1", _ad);
                    s.Parameters.AddWithValue("p2", _soyad);
                    s.Parameters.AddWithValue("p3", hesap.TELEFON);
                    s.Parameters.AddWithValue("p4", hesap.EMAIL);
                    s.Parameters.AddWithValue("p5", _sifre);
                    s.Parameters.AddWithValue("@p6", hesap.YETKI);
                    s.ExecuteNonQuery();
                    bag.Baglanti().Close();
                    kontrol = true;
                }
                else
                {
                    kontrol = false;
                }
                
            }
            catch
            {
                         
            }

            return kontrol;

        }
        public bool KayitSil(Accounts hesap)
        {
            bool kontrol = false;
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE from  tbl_kullanicilar where ID=@p1", bag.Baglanti());
                cmd.Parameters.AddWithValue("@p1", hesap.ID);
                cmd.ExecuteNonQuery();
                bag.Baglanti().Close();
                kontrol = true;
            }
            catch
            {
            }
            return kontrol;
        }
        public bool Guncelleme(Accounts hesap)
        {
            bool kontrol = false;
            try
            {
               // if (TekrarKayitKontrol(hesap.EMAIL,hesap.ID,"Güncelle"))
                //{



                 
                SqlCommand cmd;// = new SqlCommand(sorgu, bag.Baglanti());
                if (this.yetki == 2)
                    {
                    cmd = new SqlCommand("UPDATE tbl_kullanicilar set YETKI = @p1 , AKTIF=1 where ID = @p2", bag.Baglanti());
                    cmd.Parameters.AddWithValue("@p1", hesap.YETKI);
                    cmd.Parameters.AddWithValue("@p2", hesap.ID);
                    //sorgu = "UPDATE tbl_kullanicilar set YETKI = @p1 where ID = @p2";
                }
                    else
                    {
                    cmd = new SqlCommand("UPDATE tbl_kullanicilar set AD=@p3, SOYAD=@p4, MAIL=@p5,TELEFON=@p6,SIFRE=@p7 where ID = @p2", bag.Baglanti());
                    //sorgu = "UPDATE tbl_kullanicilar set AD=@p3, SOYAD=@p4, MAIL=@p5,TELEFON=@p6,SIFRE=@p7 where ID = @p2";
                    cmd.Parameters.AddWithValue("@p2", hesap.ID);
                    cmd.Parameters.AddWithValue("@p3", hesap.AD);
                    cmd.Parameters.AddWithValue("@p4", hesap.SOYAD);
                    cmd.Parameters.AddWithValue("@p5", hesap.EMAIL);
                    cmd.Parameters.AddWithValue("@p6", hesap.TELEFON);
                    cmd.Parameters.AddWithValue("@p7", hesap.SIFRE);
                }
                    //SqlCommand cmd = new SqlCommand(sorgu, bag.Baglanti());
                    //cmd.Parameters.AddWithValue("@p1", hesap.YETKI);
                    //cmd.Parameters.AddWithValue("@p2", hesap.ID);
                    //cmd.Parameters.AddWithValue("@p3", hesap.AD);
                    //cmd.Parameters.AddWithValue("@p4", hesap.SOYAD);
                    //cmd.Parameters.AddWithValue("@p5", hesap.EMAIL);
                    //cmd.Parameters.AddWithValue("@p6", hesap.TELEFON);


                    //cmd.Parameters.AddWithValue("@p7", hesap.SIFRE);

                    cmd.ExecuteNonQuery();
                    bag.Baglanti().Close();
                    kontrol = true;
               // }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return kontrol;

        }

       



        private bool TekrarKayitKontrol(string email,int id=0,string kayit_Tipi="Yeni") 
        {
            bool onay = false;
            bag.Baglanti();
            string sorgu = "";

            if (kayit_Tipi=="Yeni")
            {
                sorgu = "select * from tbl_kullanicilar where EMAIL=@p1";
            }
            else
            {
                sorgu = "select * from tbl_kullanicilar where EMAIL=@p1 and ID!=@p2";

            }
            SqlCommand s = new SqlCommand(sorgu, bag.Baglanti());
            s.Parameters.AddWithValue("p1", email);
            s.Parameters.AddWithValue("p2", id);


            SqlDataReader dr = s.ExecuteReader();
            if (dr.Read())
            {
                onay = false;
            }
            else
            {
                onay = true;
            }
            bag.Baglanti().Close();

            return onay;
            
        }

        public void Kullanici_Sil(int id)
        {
            if (id>0)
            {
                

                SqlCommand s = new SqlCommand("UPDATE  tbl_kullanicilar set AKTIF=0 where ID=@p1", bag.Baglanti());
                s.Parameters.AddWithValue("p1", id);
                s.ExecuteNonQuery();
                bag.Baglanti().Close();



            }

        }

      

        private string sifrele(string sifrelenecekmetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);
            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();

        }

        
    }
}
