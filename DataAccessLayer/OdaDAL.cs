using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OdaDAL
    {
        private DBHelper dbHelper;
        public OdaDAL()
        {
            dbHelper = new DBHelper();
        }
        public List<OdaEntity> BosOdaGetir()
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT OdaNo FROM Tbl_Oda WHERE OdaKapasite != OdaAktif";
            List<OdaEntity> Odalar = new List<OdaEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                OdaEntity oda = new OdaEntity();
                oda.OdaNo = int.Parse(dr["OdaNo"].ToString());

                Odalar.Add(oda);
            }
            return Odalar;
        }
    }
}
