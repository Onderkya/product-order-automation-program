using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace XYZ_Bilisim
{
    public class Account
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int Yetki { get; set; }
        public bool Aktif { get; set; }
        public string Sifre { get; set; }



        public void KayitOl(Account yenihesap)
        {
            if (tekrarKayitKontrol(yenihesap.Email))
            {
                Baglan b = new Baglan();
                b.baglanti();
                SqlCommand cmd = new SqlCommand("insert into tbl_kullanicilar (AD,SOYAD,TELEFON,EMAIL,YETKI_TIPI,AKTIF,SIFRE) values (@ad,@soyad,@tlf,@email,@yetki,@aktif,@sifre)", b.baglanti());
                cmd.Parameters.Add("@ad", yenihesap.Ad);
                cmd.Parameters.Add("@soyad", yenihesap.Soyad);
                cmd.Parameters.Add("@tlf", yenihesap.Telefon);
                cmd.Parameters.Add("@email", yenihesap.Email);
                cmd.Parameters.Add("@yetki", yenihesap.Yetki);
                cmd.Parameters.Add("@aktif", yenihesap.Aktif);
                Crypt cr = new Crypt();
                cmd.Parameters.Add("@sifre", Crypt.sifrele(yenihesap.Sifre));
                cmd.ExecuteNonQuery();
                b.baglanti().Close();
            }
        }



        public static bool tekrarKayitKontrol(string email, int id=0)
        {
            bool onay = false;
            Baglan b = new Baglan();
            b.baglanti();
            string sorgu = "";
            if (id == 0)
                sorgu = "select * from tbl_kullanicilar where EMAIL=@email";
            else
                sorgu = "select * from tbl_kullanicilar where EMAIL=@email and ID!=@id";

            SqlCommand cmd = new SqlCommand(sorgu, b.baglanti());
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                onay = false;
            else
                onay = true;
            b.baglanti().Close();
            return onay;
        }



        public bool Duzenle(Account hesap, string duzenleme_tipi="diğer")
        {
            bool dzn = false;
            try
            {
                Baglan b = new Baglan();
                b.baglanti();
                string sorgu="";
                if (duzenleme_tipi == "kişisel")
                    sorgu = "update tbl_kullanicilar set AD=@ad, SOYAD=@soyad, TELEFON=@tlf, EMAIL=@email where ID=@id";
                else
                    sorgu = "update tbl_kullanicilar set YETKI_TIPI=@yetki, AKTIF=1 where ID=@id";
                SqlCommand cmd = new SqlCommand(sorgu, b.baglanti());
                cmd.Parameters.AddWithValue("@ad", hesap.Ad);
                cmd.Parameters.AddWithValue("@soyad", hesap.Soyad);
                cmd.Parameters.AddWithValue("@tlf", hesap.Telefon);
                cmd.Parameters.AddWithValue("@email", hesap.Email);
                cmd.Parameters.AddWithValue("@yetki", hesap.Yetki);
                cmd.Parameters.AddWithValue("@id", hesap.ID);
                cmd.ExecuteNonQuery();
                b.baglanti().Close();
                dzn = true;
            }
            catch
            {

            }
            return dzn;
        }



        public bool Sil(int id)
        {
            bool dzn = false;
            try
            {
                Baglan b = new Baglan();
                b.baglanti();
                SqlCommand cmd = new SqlCommand("update tbl_kullanicilar set AKTIF=0 where ID=@id", b.baglanti());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                b.baglanti().Close();
                dzn = true;
            }
            catch
            {

            }
            return dzn;
        }



        public bool SifreDegistir(int id, string eskisifre, string yenisifre)
        {
            bool onay = false;

            try 
            {	        
		        Baglan b = new Baglan();
                b.baglanti();
                SqlCommand cmd = new SqlCommand("select * from tbl_kullanicilar where ID=@id and SIFRE=@eskisifre", b.baglanti());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@eskisifre", Crypt.sifrele(eskisifre));
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    b.baglanti().Close();
                    b.baglanti();
                    SqlCommand cmd2 = new SqlCommand("update tbl_kullanicilar set SIFRE=@yenisifre where ID=@id", b.baglanti());
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.Parameters.AddWithValue("@yenisifre", Crypt.sifrele(yenisifre));
                    cmd2.ExecuteNonQuery();
                    b.baglanti().Close();
                    onay = true;
                }
            }
            catch
            {

            }

            return onay;
        }




    }
}
