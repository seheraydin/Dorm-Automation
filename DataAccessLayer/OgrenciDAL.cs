using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OgrenciDAL
    {
        private DBHelper dbHelper;
        public OgrenciDAL()
        {
            dbHelper = new DBHelper();
        }
        public void OgrenciEkle(OgrenciEntity Ogrenci)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "Insert Into Tbl_Ogrenci(OgrenciAd) Values(@OgrenciAd)";
            cmd.Parameters.AddWithValue("@OgrenciAd", Ogrenci.OgrenciAd);
            cmd.ExecuteNonQuery();
        }
    }
}
