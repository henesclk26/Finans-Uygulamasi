namespace FinansUygulaması
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwIslemler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lbl98 = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.lblsd = new System.Windows.Forms.Label();
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.lblblblbl = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwIslemler
            // 
            this.dgwIslemler.AllowUserToAddRows = false;
            this.dgwIslemler.AllowUserToDeleteRows = false;
            this.dgwIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIslemler.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgwIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTarih,
            this.colTur,
            this.colKategori,
            this.colAciklama,
            this.colTutar});
            this.dgwIslemler.Location = new System.Drawing.Point(12, 86);
            this.dgwIslemler.Name = "dgwIslemler";
            this.dgwIslemler.ReadOnly = true;
            this.dgwIslemler.RowHeadersWidth = 51;
            this.dgwIslemler.RowTemplate.Height = 24;
            this.dgwIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwIslemler.Size = new System.Drawing.Size(758, 298);
            this.dgwIslemler.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 57);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Gelir Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGider
            // 
            this.btnGider.Location = new System.Drawing.Point(226, 57);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(135, 23);
            this.btnGider.TabIndex = 2;
            this.btnGider.Text = "Gider Ekle";
            this.btnGider.UseVisualStyleBackColor = true;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(429, 57);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(635, 57);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(135, 23);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lbl98
            // 
            this.lbl98.AutoSize = true;
            this.lbl98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl98.Location = new System.Drawing.Point(12, 400);
            this.lbl98.Name = "lbl98";
            this.lbl98.Size = new System.Drawing.Size(88, 16);
            this.lbl98.TabIndex = 5;
            this.lbl98.Text = "Toplam Gelir:";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(103, 400);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(33, 16);
            this.lblToplamGelir.TabIndex = 6;
            this.lblToplamGelir.Text = "0 TL";
            // 
            // lblsd
            // 
            this.lblsd.AutoSize = true;
            this.lblsd.Location = new System.Drawing.Point(223, 400);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(93, 16);
            this.lblsd.TabIndex = 7;
            this.lblsd.Text = "Toplam Gider:";
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Location = new System.Drawing.Point(317, 400);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(33, 16);
            this.lblToplamGider.TabIndex = 8;
            this.lblToplamGider.Text = "0 TL";
            // 
            // lblblblbl
            // 
            this.lblblblbl.AutoSize = true;
            this.lblblblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblblblbl.Location = new System.Drawing.Point(426, 399);
            this.lblblblbl.Name = "lblblblbl";
            this.lblblblbl.Size = new System.Drawing.Size(54, 17);
            this.lblblblbl.TabIndex = 9;
            this.lblblblbl.Text = "Bakiye:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(486, 400);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(33, 16);
            this.lblBakiye.TabIndex = 10;
            this.lblBakiye.Text = "0 TL";
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.MinimumWidth = 6;
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            // 
            // colTur
            // 
            this.colTur.HeaderText = "Tür";
            this.colTur.MinimumWidth = 6;
            this.colTur.Name = "colTur";
            this.colTur.ReadOnly = true;
            // 
            // colKategori
            // 
            this.colKategori.HeaderText = "Kategori";
            this.colKategori.MinimumWidth = 6;
            this.colKategori.Name = "colKategori";
            this.colKategori.ReadOnly = true;
            // 
            // colAciklama
            // 
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.MinimumWidth = 6;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // colTutar
            // 
            this.colTutar.HeaderText = "Tutar";
            this.colTutar.MinimumWidth = 6;
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblblblbl);
            this.Controls.Add(this.lblToplamGider);
            this.Controls.Add(this.lblsd);
            this.Controls.Add(this.lblToplamGelir);
            this.Controls.Add(this.lbl98);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwIslemler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kişisel Finans Takip";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIslemler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGider;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lbl98;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label lblsd;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.Label lblblblbl;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
    }
}

