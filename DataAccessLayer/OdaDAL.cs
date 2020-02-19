using System;
using System.Collections.Generic;
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
    }
}
