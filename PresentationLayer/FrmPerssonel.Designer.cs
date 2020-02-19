namespace PresentationLayer
{
    partial class FrmPerssonel
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
            this.txtPerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPerKaydet = new System.Windows.Forms.Button();
            this.btnnPerSil = new System.Windows.Forms.Button();
            this.btnPerGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPerId
            // 
            this.txtPerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPerId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerId.Location = new System.Drawing.Point(145, 26);
            this.txtPerId.Name = "txtPerId";
            this.txtPerId.Size = new System.Drawing.Size(222, 26);
            this.txtPerId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel  ID:";
            // 
            // txtPerAd
            // 
            this.txtPerAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPerAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerAd.Location = new System.Drawing.Point(145, 72);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(222, 26);
            this.txtPerAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel  Ad:";
            // 
            // txtPerGorev
            // 
            this.txtPerGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPerGorev.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerGorev.Location = new System.Drawing.Point(145, 115);
            this.txtPerGorev.Name = "txtPerGorev";
            this.txtPerGorev.Size = new System.Drawing.Size(222, 26);
            this.txtPerGorev.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel  Görev:";
            // 
            // btnPerKaydet
            // 
            this.btnPerKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerKaydet.Location = new System.Drawing.Point(12, 173);
            this.btnPerKaydet.Name = "btnPerKaydet";
            this.btnPerKaydet.Size = new System.Drawing.Size(102, 38);
            this.btnPerKaydet.TabIndex = 8;
            this.btnPerKaydet.Text = "Kaydet";
            this.btnPerKaydet.UseVisualStyleBackColor = true;
            // 
            // btnnPerSil
            // 
            this.btnnPerSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnPerSil.Location = new System.Drawing.Point(141, 173);
            this.btnnPerSil.Name = "btnnPerSil";
            this.btnnPerSil.Size = new System.Drawing.Size(102, 38);
            this.btnnPerSil.TabIndex = 9;
            this.btnnPerSil.Text = "Sil";
            this.btnnPerSil.UseVisualStyleBackColor = true;
            // 
            // btnPerGuncelle
            // 
            this.btnPerGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerGuncelle.Location = new System.Drawing.Point(265, 173);
            this.btnPerGuncelle.Name = "btnPerGuncelle";
            this.btnPerGuncelle.Size = new System.Drawing.Size(102, 38);
            this.btnPerGuncelle.TabIndex = 10;
            this.btnPerGuncelle.Text = "Güncelle";
            this.btnPerGuncelle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 168);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmPerssonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(386, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPerGuncelle);
            this.Controls.Add(this.btnnPerSil);
            this.Controls.Add(this.btnPerKaydet);
            this.Controls.Add(this.txtPerGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPerId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerssonel";
            this.Text = "Personel Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerGorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPerKaydet;
        private System.Windows.Forms.Button btnnPerSil;
        private System.Windows.Forms.Button btnPerGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}