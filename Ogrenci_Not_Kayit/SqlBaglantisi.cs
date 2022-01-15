using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ogrenci_Not_Kayit
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-GAMZE;Initial Catalog=OgrenciNotKayitDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
