namespace PresentationLayer
{
    partial class FrmTaksitOdeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtTaksitOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaksitKalan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgwBorclar = new System.Windows.Forms.DataGridView();
            this.dboYurtOtomasyonDataSet1 = new PresentationLayer.DboYurtOtomasyonDataSet1();
            this.tblBorcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BorcTableAdapter = new PresentationLayer.DboYurtOtomasyonDataSet1TableAdapters.Tbl_BorcTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboYurtOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAd.Location = new System.Drawing.Point(144, 302);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(206, 26);
            this.txtOgrenciAd.TabIndex = 1;
            // 
            // txtTaksitOdenen
            // 
            this.txtTaksitOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaksitOdenen.Location = new System.Drawing.Point(467, 257);
            this.txtTaksitOdenen.Name = "txtTaksitOdenen";
            this.txtTaksitOdenen.Size = new System.Drawing.Size(206, 26);
            this.txtTaksitOdenen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(359, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödenen:";
            // 
            // txtTaksitKalan
            // 
            this.txtTaksitKalan.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaksitKalan.Location = new System.Drawing.Point(467, 300);
            this.txtTaksitKalan.Name = "txtTaksitKalan";
            this.txtTaksitKalan.Size = new System.Drawing.Size(206, 26);
            this.txtTaksitKalan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalan Borç:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(467, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ödeme Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwBorclar
            // 
            this.dgwBorclar.AutoGenerateColumns = false;
            this.dgwBorclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBorclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciKalanBorcDataGridViewTextBoxColumn});
            this.dgwBorclar.DataSource = this.tblBorcBindingSource;
            this.dgwBorclar.Location = new System.Drawing.Point(12, 12);
            this.dgwBorclar.Name = "dgwBorclar";
            this.dgwBorclar.Size = new System.Drawing.Size(686, 209);
            this.dgwBorclar.TabIndex = 7;
            this.dgwBorclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBorclar_CellClick);
            // 
            // dboYurtOtomasyonDataSet1
            // 
            this.dboYurtOtomasyonDataSet1.DataSetName = "DboYurtOtomasyonDataSet1";
            this.dboYurtOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBorcBindingSource
            // 
            this.tblBorcBindingSource.DataMember = "Tbl_Borc";
            this.tblBorcBindingSource.DataSource = this.dboYurtOtomasyonDataSet1;
            // 
            // tbl_BorcTableAdapter
            // 
            this.tbl_BorcTableAdapter.ClearBeforeFill = true;
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
            // ogrenciKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrenciKalanBorcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrenciKalanBorc";
            this.ogrenciKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrenciKalanBorc";
            this.ogrenciKalanBorcDataGridViewTextBoxColumn.Name = "ogrenciKalanBorcDataGridViewTextBoxColumn";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(144, 340);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(206, 26);
            this.txtOgrenciSoyad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Soyad:";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciId.Location = new System.Drawing.Point(144, 258);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(206, 26);
            this.txtOgrenciId.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Öğrenci ID:";
            // 
            // FrmTaksitOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 470);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwBorclar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTaksitKalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaksitOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmTaksitOdeme";
            this.Text = "Ödenenler";
            this.Load += new System.EventHandler(this.FrmTaksitOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboYurtOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorcBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtTaksitOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaksitKalan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgwBorclar;
        private DboYurtOtomasyonDataSet1 dboYurtOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource tblBorcBindingSource;
        private DboYurtOtomasyonDataSet1TableAdapters.Tbl_BorcTableAdapter tbl_BorcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label6;
    }
}