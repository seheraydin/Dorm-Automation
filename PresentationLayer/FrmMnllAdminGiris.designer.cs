namespace PresentationLayer
{
    partial class FrmMnllAdminGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMnlAdminKulAdi = new System.Windows.Forms.TextBox();
            this.txtMnlKulSifre = new System.Windows.Forms.TextBox();
            this.btnMnlAdminGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Yurt Kayıt Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(156, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // txtMnlAdminKulAdi
            // 
            this.txtMnlAdminKulAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMnlAdminKulAdi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMnlAdminKulAdi.Location = new System.Drawing.Point(208, 113);
            this.txtMnlAdminKulAdi.Name = "txtMnlAdminKulAdi";
            this.txtMnlAdminKulAdi.Size = new System.Drawing.Size(183, 26);
            this.txtMnlAdminKulAdi.TabIndex = 6;
            // 
            // txtMnlKulSifre
            // 
            this.txtMnlKulSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMnlKulSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMnlKulSifre.Location = new System.Drawing.Point(208, 152);
            this.txtMnlKulSifre.Name = "txtMnlKulSifre";
            this.txtMnlKulSifre.Size = new System.Drawing.Size(183, 26);
            this.txtMnlKulSifre.TabIndex = 7;
            // 
            // btnMnlAdminGiris
            // 
            this.btnMnlAdminGiris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMnlAdminGiris.Location = new System.Drawing.Point(248, 203);
            this.btnMnlAdminGiris.Name = "btnMnlAdminGiris";
            this.btnMnlAdminGiris.Size = new System.Drawing.Size(108, 38);
            this.btnMnlAdminGiris.TabIndex = 8;
            this.btnMnlAdminGiris.Text = "Giriş Yap";
            this.btnMnlAdminGiris.UseVisualStyleBackColor = true;
            // 
            // FrmMnllAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(555, 308);
            this.Controls.Add(this.btnMnlAdminGiris);
            this.Controls.Add(this.txtMnlKulSifre);
            this.Controls.Add(this.txtMnlAdminKulAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMnllAdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMnlAdminKulAdi;
        private System.Windows.Forms.TextBox txtMnlKulSifre;
        private System.Windows.Forms.Button btnMnlAdminGiris;
    }
}