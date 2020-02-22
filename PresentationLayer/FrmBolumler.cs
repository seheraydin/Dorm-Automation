using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboYurtOtomasyonDataSet.Tbl_Bolum' table. You can move, or remove it, as needed.
            this.tbl_BolumTableAdapter.Fill(this.dboYurtOtomasyonDataSet.Tbl_Bolum);

        }
    }
}
