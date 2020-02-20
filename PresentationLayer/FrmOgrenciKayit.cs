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
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();
        }
        BolumDAL Bdal = new BolumDAL();
        OdaDAL Odal = new OdaDAL();
        private void FrmOgrenciKayit_Load(object sender, EventArgs e)
        {
            List<BolumEntity> bolumler = Bdal.BolumGetir();
            for (int i = 0; i < bolumler.Count; i++)
            {
                cmbOgrBolum.Items.Add(bolumler[i].BolumAd.ToString());
            }

            List<OdaEntity> odalar = Odal.BosOdaGetir();
            for (int i = 0; i < odalar.Count; i++)
            {
                cmbOgrOdaNo.Items.Add(odalar[i].OdaNo.ToString());
            }

        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciEntity ogrenci = new OgrenciEntity();
            ogrenci.OgrenciAd = txtOgrAd.Text;
            ogrenci.OgrenciSoyad = txtOgrSoyad.Text;
            ogrenci.OgrenciTC = mskTxtOgrTC.Text;
            ogrenci.OgrenciTelefon = mskTxtOgrTel.Text;
            ogrenci.OgrenciDogumTarihi = mskTxtOgrTarih.Text;
            ogrenci.OgrenciVeliAdSoyad = txtVeliAdSoyad.Text;
            ogrenci.OgrenciVeliTelefon = mskTxtVeliTel.Text;
            ogrenci.OgrenciAdres = rchTxtAdres.Text;
            ogrenci.OgrenciOdaNo = cmbOgrOdaNo.Text;

            OgrenciDAL ogrDal = new OgrenciDAL();
            ogrDal.OgrenciEkle(ogrenci);

        }
    }
}
