using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BolumDAL
    {
        private DBHelper dbHelper;
        public BolumDAL()
        {
            dbHelper = new DBHelper();
        }
        //Bolum Ekle Method
        public void BolumEkle(BolumEntity Bolum)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "Insert Into Tbl_Bolum(BolumAd) Values(@BolumAd)";
            cmd.Parameters.AddWithValue("@BolumAd", Bolum.BolumAd);
            cmd.ExecuteNonQuery();
        }
        //Bolum Sil Method
        public void BolumSil(BolumEntity Bolum)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "DELETE FROM Tbl_Bolum WHERE BolumID = @BolumID";
            cmd.Parameters.AddWithValue("@BolumID", Bolum.BolumID);
            cmd.ExecuteNonQuery();
        }
        //Bolum Guncelle Method
        public void BolumGuncelle(BolumEntity Bolum)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "UPDATE Tbl_Bolum SET BolumAd = @BolumAd WHERE BolumID = @BolumID";
            cmd.Parameters.AddWithValue("@BolumAd", Bolum.BolumAd);
            cmd.Parameters.AddWithValue("@BolumID", Bolum.BolumID);
            cmd.ExecuteNonQuery();
        }

    }
}
