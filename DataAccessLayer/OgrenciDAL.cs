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
            cmd.CommandText = "OgrenciEkle @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9 ";
            cmd.Parameters.AddWithValue("@p1", Ogrenci.OgrenciAd.ToString());
            cmd.Parameters.AddWithValue("@p2", Ogrenci.OgrenciSoyad);
            cmd.Parameters.AddWithValue("@p3", Ogrenci.OgrenciTC);
            cmd.Parameters.AddWithValue("@p4", Ogrenci.OgrenciTelefon);
            cmd.Parameters.AddWithValue("@p5", Ogrenci.OgrenciDogumTarihi);
            cmd.Parameters.AddWithValue("@p6", Ogrenci.OgrenciVeliAdSoyad);
            cmd.Parameters.AddWithValue("@p7", Ogrenci.OgrenciVeliTelefon);
            cmd.Parameters.AddWithValue("@p8", Ogrenci.OgrenciAdres);
            cmd.Parameters.AddWithValue("@p9", Ogrenci.OgrenciOdaNo);
            cmd.ExecuteNonQuery();
        }
    }
}
