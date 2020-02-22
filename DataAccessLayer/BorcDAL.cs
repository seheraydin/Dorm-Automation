using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BorcDAL
    {
        private DBHelper dbHelper;
        public BorcDAL()
        {
            dbHelper = new DBHelper();
        }
        public void OgrenciBorcEkle(BorcEntity Borc)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "insert into Tbl_Borc(OgrenciAd,OgrenciSoyad,OgrenciKalanborc) VALUES (@p1,@p2,@p3) ";
            cmd.Parameters.AddWithValue("@p1", Borc.OgrenciAd);
            cmd.Parameters.AddWithValue("@p2", Borc.OgrenciSoyad);
            cmd.Parameters.AddWithValue("@p3", Borc.OgrenciKalanBorc);
            cmd.ExecuteNonQuery();
        }
        public void OgrenciBorcGuncelle(BorcEntity Borc)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "update Tbl_Borc set OgrenciAd = @p1,OgrenciSoyad =@p2,OgrenciKalanborc=@p3  where OgrenciID = @p4";
            cmd.Parameters.AddWithValue("@p1", Borc.OgrenciAd);
            cmd.Parameters.AddWithValue("@p2", Borc.OgrenciSoyad);
            cmd.Parameters.AddWithValue("@p3", Borc.OgrenciKalanBorc);
            cmd.Parameters.AddWithValue("@p4", Borc.OgrenciID);
            cmd.ExecuteNonQuery();
        }
    }
}
