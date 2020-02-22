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
    public partial class FrmTaksitOdeme : Form
    {
        public FrmTaksitOdeme()
        {
            InitializeComponent();
        }

        private void FrmTaksitOdeme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboYurtOtomasyonDataSet1.Tbl_Borc' table. You can move, or remove it, as needed.
            this.tbl_BorcTableAdapter.Fill(this.dboYurtOtomasyonDataSet1.Tbl_Borc);

        }
        BorcEntity borc = new BorcEntity();
        private void dgwBorclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgwBorclar.SelectedCells[0].RowIndex;

            borc.OgrenciID = int.Parse(dgwBorclar.Rows[secilen].Cells[0].Value.ToString());
            borc.OgrenciAd = dgwBorclar.Rows[secilen].Cells[1].Value.ToString();
            borc.OgrenciSoyad = dgwBorclar.Rows[secilen].Cells[2].Value.ToString();
            borc.OgrenciKalanBorc = int.Parse(dgwBorclar.Rows[secilen].Cells[3].Value.ToString());

            txtOgrenciId.Text = (secilen + 1).ToString();
            txtOgrenciAd.Text = borc.OgrenciAd;
            txtOgrenciSoyad.Text = borc.OgrenciSoyad;
            txtTaksitKalan.Text = borc.OgrenciKalanBorc.ToString();

            


        }
        BorcDAL borcDAL = new BorcDAL();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                borc.OgrenciKalanBorc -= int.Parse(txtTaksitOdenen.Text);
                borcDAL.OgrenciBorcGuncelle(borc);
                MessageBox.Show("Ödeme Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.tbl_BorcTableAdapter.Fill(this.dboYurtOtomasyonDataSet1.Tbl_Borc);
            }
            catch (Exception)
            {
                MessageBox.Show("Ödeme Yapılamadı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
