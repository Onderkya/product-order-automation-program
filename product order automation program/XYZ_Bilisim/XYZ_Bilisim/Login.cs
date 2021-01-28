using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace XYZ_Bilisim
{
    public class Login
    {
        public static Account _hesap;

        public Login()
        {
            if (_hesap == null)
                _hesap = new Account();
        }

        public bool GirisYap(string email, string sifre, string yetki)
        {
            bool giris = false;
            Baglan b = new Baglan();
            b.baglanti();
            SqlCommand cmd = new SqlCommand("select * from tbl_kullanicilar inner join tbl_yetki on tbl_kullanicilar.YETKI_TIPI=tbl_yetki.ID where AKTIF=1 and EMAIL=@email and SIFRE=@sifre and YETKI_ADI=@yetki", b.baglanti());
            cmd.Parameters.AddWithValue("@email",email.Trim());
            cmd.Parameters.AddWithValue("@sifre",Crypt.sifrele(sifre.Trim()));
            cmd.Parameters.AddWithValue("@yetki", yetki);
            SqlDataReader dr=cmd.ExecuteReader();
            if(dr.Read())
            {
                _hesap.ID = Convert.ToInt16(dr[0]);
                _hesap.Ad = dr["AD"].ToString();
                _hesap.Soyad = dr["SOYAD"].ToString();
                _hesap.Email = dr["EMAIL"].ToString();
                _hesap.Telefon = dr["TELEFON"].ToString();
                _hesap.Yetki = Convert.ToInt16(dr["YETKI_TIPI"]);
                giris = true;
            }
            return giris;
        }



    }
}
