namespace PresentationLayer
{
    partial class FrmOgrenciKayit
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
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTxtOgrTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTxtOgrTarih = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.cmbOgrOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTxtVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rchTxtAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrAd.Location = new System.Drawing.Point(134, 8);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(222, 26);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(134, 40);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(222, 26);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // mskTxtOgrTC
            // 
            this.mskTxtOgrTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTxtOgrTC.Location = new System.Drawing.Point(134, 72);
            this.mskTxtOgrTC.Mask = "00000000000";
            this.mskTxtOgrTC.Name = "mskTxtOgrTC";
            this.mskTxtOgrTC.Size = new System.Drawing.Size(222, 20);
            this.mskTxtOgrTC.TabIndex = 5;
            this.mskTxtOgrTC.ValidatingType = typeof(int);
            // 
            // mskTxtOgrTel
            // 
            this.mskTxtOgrTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTxtOgrTel.Location = new System.Drawing.Point(134, 98);
            this.mskTxtOgrTel.Mask = "(999) 000-0000";
            this.mskTxtOgrTel.Name = "mskTxtOgrTel";
            this.mskTxtOgrTel.Size = new System.Drawing.Size(222, 20);
            this.mskTxtOgrTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // mskTxtOgrTarih
            // 
            this.mskTxtOgrTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTxtOgrTarih.Location = new System.Drawing.Point(134, 125);
            this.mskTxtOgrTarih.Mask = "00/00/0000";
            this.mskTxtOgrTarih.Name = "mskTxtOgrTarih";
            this.mskTxtOgrTarih.Size = new System.Drawing.Size(222, 20);
            this.mskTxtOgrTarih.TabIndex = 9;
            this.mskTxtOgrTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // cmbOgrBolum
            // 
            this.cmbOgrBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbOgrBolum.FormattingEnabled = true;
            this.cmbOgrBolum.Location = new System.Drawing.Point(134, 151);
            this.cmbOgrBolum.Name = "cmbOgrBolum";
            this.cmbOgrBolum.Size = new System.Drawing.Size(222, 21);
            this.cmbOgrBolum.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOgrMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrMail.Location = new System.Drawing.Point(134, 178);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(222, 26);
            this.txtOgrMail.TabIndex = 13;
            // 
            // cmbOgrOdaNo
            // 
            this.cmbOgrOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbOgrOdaNo.FormattingEnabled = true;
            this.cmbOgrOdaNo.Location = new System.Drawing.Point(134, 210);
            this.cmbOgrOdaNo.Name = "cmbOgrOdaNo";
            this.cmbOgrOdaNo.Size = new System.Drawing.Size(222, 21);
            this.cmbOgrOdaNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda Numarası:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(134, 237);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(222, 26);
            this.txtVeliAdSoyad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(25, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veli Ad Soyad";
            // 
            // mskTxtVeliTel
            // 
            this.mskTxtVeliTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTxtVeliTel.Location = new System.Drawing.Point(134, 269);
            this.mskTxtVeliTel.Mask = "(999) 000-0000";
            this.mskTxtVeliTel.Name = "mskTxtVeliTel";
            this.mskTxtVeliTel.Size = new System.Drawing.Size(222, 20);
            this.mskTxtVeliTel.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(28, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres:";
            // 
            // rchTxtAdres
            // 
            this.rchTxtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rchTxtAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTxtAdres.Location = new System.Drawing.Point(134, 295);
            this.rchTxtAdres.Name = "rchTxtAdres";
            this.rchTxtAdres.Size = new System.Drawing.Size(222, 123);
            this.rchTxtAdres.TabIndex = 21;
            this.rchTxtAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(193, 424);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 40);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(495, 471);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchTxtAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskTxtVeliTel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOgrOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOgrMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbOgrBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTxtOgrTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTxtOgrTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTxtOgrTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmOgrenciKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrenciKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTxtOgrTC;
        private System.Windows.Forms.MaskedTextBox mskTxtOgrTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTxtOgrTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOgrBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.ComboBox cmbOgrOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskTxtVeliTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchTxtAdres;
        private System.Windows.Forms.Button btnKaydet;
    }
}