using System;
using System.Collections.Generic;
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
    }
}
