namespace PresentationLayer
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.dgwBolumler = new System.Windows.Forms.DataGridView();
            this.lblBolumId = new System.Windows.Forms.Label();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.txtBolumId = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolumler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBolumler
            // 
            this.dgwBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBolumler.Location = new System.Drawing.Point(7, 210);
            this.dgwBolumler.Name = "dgwBolumler";
            this.dgwBolumler.Size = new System.Drawing.Size(564, 221);
            this.dgwBolumler.TabIndex = 0;
            // 
            // lblBolumId
            // 
            this.lblBolumId.AutoSize = true;
            this.lblBolumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumId.Location = new System.Drawing.Point(17, 38);
            this.lblBolumId.Name = "lblBolumId";
            this.lblBolumId.Size = new System.Drawing.Size(93, 20);
            this.lblBolumId.TabIndex = 1;
            this.lblBolumId.Text = "Bölüm ID :";
            // 
            // lblBolumAd
            // 
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumAd.Location = new System.Drawing.Point(14, 95);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.Size = new System.Drawing.Size(96, 20);
            this.lblBolumAd.TabIndex = 2;
            this.lblBolumAd.Text = "Bölüm Ad :";
            // 
            // txtBolumId
            // 
            this.txtBolumId.Location = new System.Drawing.Point(116, 40);
            this.txtBolumId.Name = "txtBolumId";
            this.txtBolumId.Size = new System.Drawing.Size(174, 20);
            this.txtBolumId.TabIndex = 3;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(116, 97);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(174, 20);
            this.txtBolumAd.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(384, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(143, 44);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(384, 78);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 44);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(384, 128);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 44);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(576, 435);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.txtBolumId);
            this.Controls.Add(this.lblBolumAd);
            this.Controls.Add(this.lblBolumId);
            this.Controls.Add(this.dgwBolumler);
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBolumler;
        private System.Windows.Forms.Label lblBolumId;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.TextBox txtBolumId;
        private System.Windows.Forms.TextBox txtBolumAd;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}