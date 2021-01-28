using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace XYZ_Bilisim
{
    public class Baglan
    {
        public SqlConnection baglanti()
        {
            SqlConnection bag = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\xyz_bilisim.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TP0F9QD\SQLEXPRESS;Initial Catalog=xyz_bilisim;Integrated Security=True");
            bag.Open();
            return bag;
        }
    }
}
