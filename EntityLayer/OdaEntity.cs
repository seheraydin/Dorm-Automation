using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class OdaEntity
    {
        public int OdaID { get; set; }
        public int OdaNo { get; set; }
        public string OdaKapasite { get; set; }
        public string OdaAktif { get; set; }
        public bool OdaDurum { get; set; }

    }
}
