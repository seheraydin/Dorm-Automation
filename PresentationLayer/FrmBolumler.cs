using DataAccessLayer;
using EntityLayer;
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
        BolumDAL Bdal = new BolumDAL();
        BolumEntity bolum = new BolumEntity();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bolum.BolumAd = txtBolumAd.Text;
                Bdal.BolumEkle(bolum);
            }
            catch (Exception)
            {
                MessageBox.Show("Bölüm eklenirken hata oluştu !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bolum.BolumID = int.Parse(txtBolumId.Text);
                Bdal.BolumSil(bolum);
            }
            catch (Exception)
            {
                MessageBox.Show("Bölüm silinirken hata oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                bolum.BolumID = int.Parse(txtBolumId.Text);
                bolum.BolumAd = txtBolumAd.Text;
                Bdal.BolumGuncelle(bolum);
            }
            catch (Exception)
            {
                MessageBox.Show("Bölüm güncellenirken hata oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
