namespace PlaystationCafe
{
    partial class FrmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adisyon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBLSaatUcretiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playstationCafeDataSet1 = new PlaystationCafe.PlaystationCafeDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSecilen = new System.Windows.Forms.RadioButton();
            this.txtSecileneGore = new System.Windows.Forms.TextBox();
            this.radioBtn180 = new System.Windows.Forms.RadioButton();
            this.btnMasaAC = new System.Windows.Forms.Button();
            this.radioBtn120 = new System.Windows.Forms.RadioButton();
            this.radioBtn90 = new System.Windows.Forms.RadioButton();
            this.radioBtn60 = new System.Windows.Forms.RadioButton();
            this.radioBtn45 = new System.Windows.Forms.RadioButton();
            this.radioBtn30 = new System.Windows.Forms.RadioButton();
            this.radioBtnSuresiz = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSaatUcreti = new System.Windows.Forms.ComboBox();
            this.comboBoxBosMasalar = new System.Windows.Forms.ComboBox();
            this.btnMasaDegis = new System.Windows.Forms.Button();
            this.tBLSaatUcretiTableAdapter = new PlaystationCafe.PlaystationCafeDataSet1TableAdapters.TBLSaatUcretiTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playstationCafeDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Masa_ID,
            this._masa,
            this.AcilisTuru,
            this.BaslamaSaati,
            this.BitisSaati,
            this.sure,
            this.Tutar,
            this._tarih,
            this.Adisyon,
            this.MasaKapat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 544);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "SepetID";
            this.id.FillWeight = 55F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Masa_ID
            // 
            this.Masa_ID.DataPropertyName = "MasaID";
            this.Masa_ID.FillWeight = 105.1693F;
            this.Masa_ID.HeaderText = "Masa ID";
            this.Masa_ID.MinimumWidth = 6;
            this.Masa_ID.Name = "Masa_ID";
            this.Masa_ID.ReadOnly = true;
            // 
            // _masa
            // 
            this._masa.DataPropertyName = "Masa";
            this._masa.FillWeight = 105.1693F;
            this._masa.HeaderText = "Masa";
            this._masa.MinimumWidth = 6;
            this._masa.Name = "_masa";
            this._masa.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.FillWeight = 105.1693F;
            this.AcilisTuru.HeaderText = "Açılış Türü";
            this.AcilisTuru.MinimumWidth = 6;
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "Baslangic";
            this.BaslamaSaati.FillWeight = 130F;
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.MinimumWidth = 6;
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            // 
            // BitisSaati
            // 
            this.BitisSaati.FillWeight = 145F;
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.MinimumWidth = 6;
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            // 
            // sure
            // 
            this.sure.FillWeight = 105.1693F;
            this.sure.HeaderText = "Süre (dk)";
            this.sure.MinimumWidth = 6;
            this.sure.Name = "sure";
            this.sure.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.FillWeight = 105.1693F;
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // _tarih
            // 
            this._tarih.DataPropertyName = "Tarih";
            this._tarih.FillWeight = 135F;
            this._tarih.HeaderText = "Tarih";
            this._tarih.MinimumWidth = 6;
            this._tarih.Name = "_tarih";
            this._tarih.ReadOnly = true;
            // 
            // Adisyon
            // 
            this.Adisyon.HeaderText = "Adisyon";
            this.Adisyon.MinimumWidth = 6;
            this.Adisyon.Name = "Adisyon";
            this.Adisyon.ReadOnly = true;
            this.Adisyon.Text = "Adisyon";
            this.Adisyon.ToolTipText = "Adisyon";
            this.Adisyon.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            this.MasaKapat.FillWeight = 105.1693F;
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.MinimumWidth = 6;
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa Kapat";
            this.MasaKapat.ToolTipText = "Masa Kapat";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // tBLSaatUcretiBindingSource
            // 
            this.tBLSaatUcretiBindingSource.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource.DataSource = this.playstationCafeDataSet1;
            // 
            // playstationCafeDataSet1
            // 
            this.playstationCafeDataSet1.DataSetName = "PlaystationCafeDataSet1";
            this.playstationCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButtonSecilen);
            this.panel1.Controls.Add(this.txtSecileneGore);
            this.panel1.Controls.Add(this.radioBtn180);
            this.panel1.Controls.Add(this.btnMasaAC);
            this.panel1.Controls.Add(this.radioBtn120);
            this.panel1.Controls.Add(this.radioBtn90);
            this.panel1.Controls.Add(this.radioBtn60);
            this.panel1.Controls.Add(this.radioBtn45);
            this.panel1.Controls.Add(this.radioBtn30);
            this.panel1.Controls.Add(this.radioBtnSuresiz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboSaatUcreti);
            this.panel1.Controls.Add(this.comboBoxBosMasalar);
            this.panel1.Location = new System.Drawing.Point(1159, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 285);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonSecilen
            // 
            this.radioButtonSecilen.AutoSize = true;
            this.radioButtonSecilen.Location = new System.Drawing.Point(26, 240);
            this.radioButtonSecilen.Name = "radioButtonSecilen";
            this.radioButtonSecilen.Size = new System.Drawing.Size(17, 16);
            this.radioButtonSecilen.TabIndex = 5;
            this.radioButtonSecilen.TabStop = true;
            this.radioButtonSecilen.UseVisualStyleBackColor = true;
            // 
            // txtSecileneGore
            // 
            this.txtSecileneGore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecileneGore.Location = new System.Drawing.Point(49, 240);
            this.txtSecileneGore.Name = "txtSecileneGore";
            this.txtSecileneGore.Size = new System.Drawing.Size(26, 22);
            this.txtSecileneGore.TabIndex = 4;
            this.txtSecileneGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecileneGore_KeyPress);
            // 
            // radioBtn180
            // 
            this.radioBtn180.AutoSize = true;
            this.radioBtn180.Location = new System.Drawing.Point(26, 218);
            this.radioBtn180.Name = "radioBtn180";
            this.radioBtn180.Size = new System.Drawing.Size(49, 20);
            this.radioBtn180.TabIndex = 2;
            this.radioBtn180.TabStop = true;
            this.radioBtn180.Text = "180";
            this.radioBtn180.UseVisualStyleBackColor = true;
            this.radioBtn180.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // btnMasaAC
            // 
            this.btnMasaAC.BackColor = System.Drawing.Color.Silver;
            this.btnMasaAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaAC.Location = new System.Drawing.Point(112, 163);
            this.btnMasaAC.Name = "btnMasaAC";
            this.btnMasaAC.Size = new System.Drawing.Size(135, 52);
            this.btnMasaAC.TabIndex = 3;
            this.btnMasaAC.Text = "MASA AÇ";
            this.btnMasaAC.UseVisualStyleBackColor = false;
            this.btnMasaAC.Click += new System.EventHandler(this.btnMasaAC_Click);
            // 
            // radioBtn120
            // 
            this.radioBtn120.AutoSize = true;
            this.radioBtn120.Location = new System.Drawing.Point(26, 195);
            this.radioBtn120.Name = "radioBtn120";
            this.radioBtn120.Size = new System.Drawing.Size(49, 20);
            this.radioBtn120.TabIndex = 2;
            this.radioBtn120.TabStop = true;
            this.radioBtn120.Text = "120";
            this.radioBtn120.UseVisualStyleBackColor = true;
            this.radioBtn120.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioBtn90
            // 
            this.radioBtn90.AutoSize = true;
            this.radioBtn90.Location = new System.Drawing.Point(26, 172);
            this.radioBtn90.Name = "radioBtn90";
            this.radioBtn90.Size = new System.Drawing.Size(42, 20);
            this.radioBtn90.TabIndex = 2;
            this.radioBtn90.TabStop = true;
            this.radioBtn90.Text = "90";
            this.radioBtn90.UseVisualStyleBackColor = true;
            this.radioBtn90.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioBtn60
            // 
            this.radioBtn60.AutoSize = true;
            this.radioBtn60.Location = new System.Drawing.Point(26, 149);
            this.radioBtn60.Name = "radioBtn60";
            this.radioBtn60.Size = new System.Drawing.Size(42, 20);
            this.radioBtn60.TabIndex = 2;
            this.radioBtn60.TabStop = true;
            this.radioBtn60.Text = "60";
            this.radioBtn60.UseVisualStyleBackColor = true;
            this.radioBtn60.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioBtn45
            // 
            this.radioBtn45.AutoSize = true;
            this.radioBtn45.Location = new System.Drawing.Point(26, 126);
            this.radioBtn45.Name = "radioBtn45";
            this.radioBtn45.Size = new System.Drawing.Size(42, 20);
            this.radioBtn45.TabIndex = 2;
            this.radioBtn45.TabStop = true;
            this.radioBtn45.Text = "45";
            this.radioBtn45.UseVisualStyleBackColor = true;
            this.radioBtn45.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioBtn30
            // 
            this.radioBtn30.AutoSize = true;
            this.radioBtn30.Location = new System.Drawing.Point(26, 103);
            this.radioBtn30.Name = "radioBtn30";
            this.radioBtn30.Size = new System.Drawing.Size(42, 20);
            this.radioBtn30.TabIndex = 2;
            this.radioBtn30.TabStop = true;
            this.radioBtn30.Text = "30";
            this.radioBtn30.UseVisualStyleBackColor = true;
            this.radioBtn30.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioBtnSuresiz
            // 
            this.radioBtnSuresiz.AutoSize = true;
            this.radioBtnSuresiz.Location = new System.Drawing.Point(26, 80);
            this.radioBtnSuresiz.Name = "radioBtnSuresiz";
            this.radioBtnSuresiz.Size = new System.Drawing.Size(72, 20);
            this.radioBtnSuresiz.TabIndex = 2;
            this.radioBtnSuresiz.TabStop = true;
            this.radioBtnSuresiz.Text = "Süresiz";
            this.radioBtnSuresiz.UseVisualStyleBackColor = true;
            this.radioBtnSuresiz.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat Ücreti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boş Masalar";
            // 
            // comboSaatUcreti
            // 
            this.comboSaatUcreti.DataSource = this.tBLSaatUcretiBindingSource;
            this.comboSaatUcreti.DisplayMember = "SaatUcreti";
            this.comboSaatUcreti.FormattingEnabled = true;
            this.comboSaatUcreti.Location = new System.Drawing.Point(189, 99);
            this.comboSaatUcreti.Name = "comboSaatUcreti";
            this.comboSaatUcreti.Size = new System.Drawing.Size(58, 24);
            this.comboSaatUcreti.TabIndex = 0;
            this.comboSaatUcreti.ValueMember = "SaatiUcretiID";
            // 
            // comboBoxBosMasalar
            // 
            this.comboBoxBosMasalar.FormattingEnabled = true;
            this.comboBoxBosMasalar.Location = new System.Drawing.Point(26, 39);
            this.comboBoxBosMasalar.Name = "comboBoxBosMasalar";
            this.comboBoxBosMasalar.Size = new System.Drawing.Size(221, 24);
            this.comboBoxBosMasalar.TabIndex = 0;
            // 
            // btnMasaDegis
            // 
            this.btnMasaDegis.BackColor = System.Drawing.Color.Green;
            this.btnMasaDegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaDegis.Location = new System.Drawing.Point(1356, 494);
            this.btnMasaDegis.Name = "btnMasaDegis";
            this.btnMasaDegis.Size = new System.Drawing.Size(63, 44);
            this.btnMasaDegis.TabIndex = 3;
            this.btnMasaDegis.Text = "MASA DEĞİŞ";
            this.btnMasaDegis.UseVisualStyleBackColor = false;
            this.btnMasaDegis.Visible = false;
            this.btnMasaDegis.Click += new System.EventHandler(this.btnMasaDegis_Click);
            // 
            // tBLSaatUcretiTableAdapter
            // 
            this.tBLSaatUcretiTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(1159, 430);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(260, 42);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Silver;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ImageKey = "settingws.png";
            this.btnAyarlar.ImageList = this.ımageList2;
            this.btnAyarlar.Location = new System.Drawing.Point(1161, 494);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(51, 44);
            this.btnAyarlar.TabIndex = 3;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "settingws.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(206, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(992, 137);
            this.label3.TabIndex = 4;
            this.label3.Text = "Playstation Cafe";
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::PlaystationCafe.Properties.Resources.playstation_background_image_yu;
            this.ClientSize = new System.Drawing.Size(1431, 696);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMasaDegis);
            this.Controls.Add(this.btnAyarlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSatis_FormClosed);
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playstationCafeDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBosMasalar;
        private System.Windows.Forms.RadioButton radioBtn180;
        private System.Windows.Forms.RadioButton radioBtn120;
        private System.Windows.Forms.RadioButton radioBtn90;
        private System.Windows.Forms.RadioButton radioBtn60;
        private System.Windows.Forms.RadioButton radioBtn45;
        private System.Windows.Forms.RadioButton radioBtn30;
        private System.Windows.Forms.RadioButton radioBtnSuresiz;
        private System.Windows.Forms.Button btnMasaAC;
        private PlaystationCafeDataSet1 playstationCafeDataSet1;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource;
        private PlaystationCafeDataSet1TableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSaatUcreti;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMasaDegis;
        private System.Windows.Forms.TextBox txtSecileneGore;
        private System.Windows.Forms.RadioButton radioButtonSecilen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Adisyon;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

