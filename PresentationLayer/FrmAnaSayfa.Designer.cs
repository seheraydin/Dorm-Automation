namespace PresentationLayer
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıstatistliklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirIstatistlikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderIstatistlikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dboYurtOtomasyonDataSet = new PresentationLayer.DboYurtOtomasyonDataSet();
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OgrenciTableAdapter = new PresentationLayer.DboYurtOtomasyonDataSetTableAdapters.Tbl_OgrenciTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboYurtOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.ıstatistliklerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem,
            this.öğrenciDüzenleToolStripMenuItem});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci Düzenle";
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenleToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeAlToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderListesiToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            // 
            // giderListesiToolStripMenuItem
            // 
            this.giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            this.giderListesiToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.giderListesiToolStripMenuItem.Text = "Gider Listesi";
            // 
            // ıstatistliklerToolStripMenuItem
            // 
            this.ıstatistliklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirIstatistlikleriToolStripMenuItem,
            this.giderIstatistlikleriToolStripMenuItem});
            this.ıstatistliklerToolStripMenuItem.Name = "ıstatistliklerToolStripMenuItem";
            this.ıstatistliklerToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ıstatistliklerToolStripMenuItem.Text = "Istatistlikler";
            // 
            // gelirIstatistlikleriToolStripMenuItem
            // 
            this.gelirIstatistlikleriToolStripMenuItem.Name = "gelirIstatistlikleriToolStripMenuItem";
            this.gelirIstatistlikleriToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.gelirIstatistlikleriToolStripMenuItem.Text = "Gelir Istatistlikleri";
            // 
            // giderIstatistlikleriToolStripMenuItem
            // 
            this.giderIstatistlikleriToolStripMenuItem.Name = "giderIstatistlikleriToolStripMenuItem";
            this.giderIstatistlikleriToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.giderIstatistlikleriToolStripMenuItem.Text = "Gider Istatistlikleri";
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreIslemleriToolStripMenuItem,
            this.personelDüzenleToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreIslemleriToolStripMenuItem
            // 
            this.şifreIslemleriToolStripMenuItem.Name = "şifreIslemleriToolStripMenuItem";
            this.şifreIslemleriToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.şifreIslemleriToolStripMenuItem.Text = "Şifre Islemleri";
            // 
            // personelDüzenleToolStripMenuItem
            // 
            this.personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            this.personelDüzenleToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.personelDüzenleToolStripMenuItem.Text = "Personel Düzenle";
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.radioToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // radioToolStripMenuItem
            // 
            this.radioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radio1ToolStripMenuItem,
            this.radio2ToolStripMenuItem,
            this.radio3ToolStripMenuItem});
            this.radioToolStripMenuItem.Name = "radioToolStripMenuItem";
            this.radioToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.radioToolStripMenuItem.Text = "Radio";
            // 
            // radio1ToolStripMenuItem
            // 
            this.radio1ToolStripMenuItem.Name = "radio1ToolStripMenuItem";
            this.radio1ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.radio1ToolStripMenuItem.Text = "Radio1";
            // 
            // radio2ToolStripMenuItem
            // 
            this.radio2ToolStripMenuItem.Name = "radio2ToolStripMenuItem";
            this.radio2ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.radio2ToolStripMenuItem.Text = "Radio2";
            // 
            // radio3ToolStripMenuItem
            // 
            this.radio3ToolStripMenuItem.Name = "radio3ToolStripMenuItem";
            this.radio3ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.radio3ToolStripMenuItem.Text = "Radio3";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciOdaNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 278);
            this.dataGridView1.TabIndex = 1;
            // 
            // dboYurtOtomasyonDataSet
            // 
            this.dboYurtOtomasyonDataSet.DataSetName = "DboYurtOtomasyonDataSet";
            this.dboYurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrenciBindingSource
            // 
            this.tblOgrenciBindingSource.DataMember = "Tbl_Ogrenci";
            this.tblOgrenciBindingSource.DataSource = this.dboYurtOtomasyonDataSet;
            // 
            // tbl_OgrenciTableAdapter
            // 
            this.tbl_OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrenciOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciOdaNo";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.HeaderText = "OgrenciOdaNo";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.Name = "ogrenciOdaNoDataGridViewTextBoxColumn";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(469, 63);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(66, 18);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "TARİH";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(482, 85);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(54, 18);
            this.lblSaat.TabIndex = 3;
            this.lblSaat.Text = "SAAT";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(691, 369);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboYurtOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıstatistliklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirIstatistlikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderIstatistlikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DboYurtOtomasyonDataSet dboYurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private DboYurtOtomasyonDataSetTableAdapters.Tbl_OgrenciTableAdapter tbl_OgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
    }
}