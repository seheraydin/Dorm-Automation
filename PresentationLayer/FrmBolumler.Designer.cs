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
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.dgwBolumler = new System.Windows.Forms.DataGridView();
            this.lblBolumID = new System.Windows.Forms.Label();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.txtBolumId = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolumler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(462, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 45);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnSil.Location = new System.Drawing.Point(462, 75);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 43);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(462, 124);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 41);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // dgwBolumler
            // 
            this.dgwBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBolumler.Location = new System.Drawing.Point(3, 188);
            this.dgwBolumler.Name = "dgwBolumler";
            this.dgwBolumler.Size = new System.Drawing.Size(591, 240);
            this.dgwBolumler.TabIndex = 3;
            // 
            // lblBolumID
            // 
            this.lblBolumID.AutoSize = true;
            this.lblBolumID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumID.Location = new System.Drawing.Point(40, 39);
            this.lblBolumID.Name = "lblBolumID";
            this.lblBolumID.Size = new System.Drawing.Size(78, 16);
            this.lblBolumID.TabIndex = 4;
            this.lblBolumID.Text = "Bölüm ID :";
            // 
            // lblBolumAd
            // 
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumAd.Location = new System.Drawing.Point(34, 89);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.Size = new System.Drawing.Size(84, 16);
            this.lblBolumAd.TabIndex = 5;
            this.lblBolumAd.Text = "Bölüm AD :";
            // 
            // txtBolumId
            // 
            this.txtBolumId.Location = new System.Drawing.Point(124, 38);
            this.txtBolumId.Multiline = true;
            this.txtBolumId.Name = "txtBolumId";
            this.txtBolumId.Size = new System.Drawing.Size(164, 21);
            this.txtBolumId.TabIndex = 6;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(124, 89);
            this.txtBolumAd.Multiline = true;
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(164, 21);
            this.txtBolumAd.TabIndex = 7;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(597, 430);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.txtBolumId);
            this.Controls.Add(this.lblBolumAd);
            this.Controls.Add(this.lblBolumID);
            this.Controls.Add(this.dgwBolumler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.DataGridView dgwBolumler;
        private System.Windows.Forms.Label lblBolumID;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.TextBox txtBolumId;
        private System.Windows.Forms.TextBox txtBolumAd;
    }
}