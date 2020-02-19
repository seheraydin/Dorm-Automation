using System;
using System.Collections.Generic;
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
    }
}
