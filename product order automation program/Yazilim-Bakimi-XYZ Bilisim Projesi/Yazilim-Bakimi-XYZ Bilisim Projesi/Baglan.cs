using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Yazilim_Bakimi_XYZ_Bilisim_Projesi
{
   public  class Baglan
    {

        public Baglan()
        {

        }

        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-Q04EB8O;Initial Catalog=XYZ_Bilisim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }




    }
}
