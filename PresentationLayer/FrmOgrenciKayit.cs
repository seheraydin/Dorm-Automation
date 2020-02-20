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
    }
}
