using System;
using System.Collections.Generic;
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
    }
}
