namespace PlaystationCafe
{
    partial class frmAdisyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdisyon));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SatisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxUrunAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.Label();
            this.txtSiparisTutari = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumericAdetSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAdetSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatisID,
            this.kategori,
            this.UrunAdi,
            this.fiyati});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // SatisID
            // 
            this.SatisID.DataPropertyName = "SatisID";
            this.SatisID.HeaderText = "Satış ID";
            this.SatisID.MinimumWidth = 6;
            this.SatisID.Name = "SatisID";
            this.SatisID.ReadOnly = true;
            // 
            // kategori
            // 
            this.kategori.DataPropertyName = "kategori";
            this.kategori.HeaderText = "Kategori";
            this.kategori.MinimumWidth = 6;
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün adi";
            this.UrunAdi.MinimumWidth = 6;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // fiyati
            // 
            this.fiyati.DataPropertyName = "fiyati";
            this.fiyati.HeaderText = "Fiyatı";
            this.fiyati.MinimumWidth = 6;
            this.fiyati.Name = "fiyati";
            this.fiyati.ReadOnly = true;
            // 
            // textBoxUrunAra
            // 
            this.textBoxUrunAra.Location = new System.Drawing.Point(85, 495);
            this.textBoxUrunAra.Name = "textBoxUrunAra";
            this.textBoxUrunAra.Size = new System.Drawing.Size(188, 22);
            this.textBoxUrunAra.TabIndex = 1;
            this.textBoxUrunAra.TextChanged += new System.EventHandler(this.textBoxUrunAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün ara:";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(599, 495);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(109, 26);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürün Ekle ->";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtID.Location = new System.Drawing.Point(17, 558);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(28, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "ID";
            // 
            // txtMasa
            // 
            this.txtMasa.AutoSize = true;
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMasa.Location = new System.Drawing.Point(128, 558);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(80, 20);
            this.txtMasa.TabIndex = 2;
            this.txtMasa.Text = "Masa-ID";
            // 
            // txtSiparisTutari
            // 
            this.txtSiparisTutari.AutoSize = true;
            this.txtSiparisTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparisTutari.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtSiparisTutari.Location = new System.Drawing.Point(928, 570);
            this.txtSiparisTutari.Name = "txtSiparisTutari";
            this.txtSiparisTutari.Size = new System.Drawing.Size(0, 20);
            this.txtSiparisTutari.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._UrunAdi,
            this._fiyati,
            this.adet,
            this.Toplam});
            this.dataGridView2.Location = new System.Drawing.Point(735, 54);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(392, 435);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // _id
            // 
            this._id.DataPropertyName = "id";
            this._id.FillWeight = 30F;
            this._id.HeaderText = "ID";
            this._id.MinimumWidth = 6;
            this._id.Name = "_id";
            // 
            // _UrunAdi
            // 
            this._UrunAdi.DataPropertyName = "UrunAdi";
            this._UrunAdi.FillWeight = 79.62915F;
            this._UrunAdi.HeaderText = "Ürün Adı";
            this._UrunAdi.MinimumWidth = 6;
            this._UrunAdi.Name = "_UrunAdi";
            // 
            // _fiyati
            // 
            this._fiyati.DataPropertyName = "fiyati";
            this._fiyati.FillWeight = 112.3994F;
            this._fiyati.HeaderText = "Fiyatı";
            this._fiyati.MinimumWidth = 6;
            this._fiyati.Name = "_fiyati";
            // 
            // adet
            // 
            this.adet.DataPropertyName = "adet";
            this.adet.FillWeight = 79.62915F;
            this.adet.HeaderText = "Adet";
            this.adet.MinimumWidth = 6;
            this.adet.Name = "adet";
            // 
            // Toplam
            // 
            this.Toplam.DataPropertyName = "Toplam";
            this.Toplam.HeaderText = "Toplam";
            this.Toplam.MinimumWidth = 6;
            this.Toplam.Name = "Toplam";
            // 
            // NumericAdetSayisi
            // 
            this.NumericAdetSayisi.Location = new System.Drawing.Point(522, 499);
            this.NumericAdetSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericAdetSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericAdetSayisi.Name = "NumericAdetSayisi";
            this.NumericAdetSayisi.Size = new System.Drawing.Size(51, 22);
            this.NumericAdetSayisi.TabIndex = 5;
            this.NumericAdetSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "noun-cancel-110764.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(1074, 495);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(53, 49);
            this.btnSil.TabIndex = 6;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "noun-cancel-110764.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün listelesi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(731, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sepet:";
            // 
            // frmAdisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 595);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.NumericAdetSayisi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtSiparisTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrunAra);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdisyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adisyon Satış Sayfası";
            this.Load += new System.EventHandler(this.frmAdisyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAdetSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyati;
        private System.Windows.Forms.TextBox textBoxUrunAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunEkle;
        public System.Windows.Forms.Label txtID;
        public System.Windows.Forms.Label txtMasa;
        public System.Windows.Forms.Label txtSiparisTutari;
        private System.Windows.Forms.NumericUpDown NumericAdetSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}