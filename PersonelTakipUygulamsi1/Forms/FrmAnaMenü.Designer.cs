namespace PersonelTakipUygulamsi1.Forms
{
    partial class FrmAnaMenü
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAraçlar = new System.Windows.Forms.Panel();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.comboUnvan = new System.Windows.Forms.ComboBox();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPerNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSoyadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAraçlar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAraçlar
            // 
            this.panelAraçlar.BackColor = System.Drawing.Color.RosyBrown;
            this.panelAraçlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAraçlar.Controls.Add(this.comboDurum);
            this.panelAraçlar.Controls.Add(this.comboUnvan);
            this.panelAraçlar.Controls.Add(this.comboDepartman);
            this.panelAraçlar.Controls.Add(this.dateDogumTarihi);
            this.panelAraçlar.Controls.Add(this.label7);
            this.panelAraçlar.Controls.Add(this.label8);
            this.panelAraçlar.Controls.Add(this.label5);
            this.panelAraçlar.Controls.Add(this.label6);
            this.panelAraçlar.Controls.Add(this.textPerNo);
            this.panelAraçlar.Controls.Add(this.label4);
            this.panelAraçlar.Controls.Add(this.textTc);
            this.panelAraçlar.Controls.Add(this.label3);
            this.panelAraçlar.Controls.Add(this.textSoyadı);
            this.panelAraçlar.Controls.Add(this.label2);
            this.panelAraçlar.Controls.Add(this.textAdı);
            this.panelAraçlar.Controls.Add(this.label1);
            this.panelAraçlar.Location = new System.Drawing.Point(12, 12);
            this.panelAraçlar.Name = "panelAraçlar";
            this.panelAraçlar.Size = new System.Drawing.Size(552, 406);
            this.panelAraçlar.TabIndex = 0;
            // 
            // comboDurum
            // 
            this.comboDurum.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Items.AddRange(new object[] {
            "Aktif Çalışan",
            "Sözleşmesi Askıda",
            "Ücretsiz İzinde",
            "İşten Çıkarılma ",
            "İstifa"});
            this.comboDurum.Location = new System.Drawing.Point(238, 354);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(298, 35);
            this.comboDurum.TabIndex = 13;
            this.comboDurum.Tag = "Durumu";
            // 
            // comboUnvan
            // 
            this.comboUnvan.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboUnvan.FormattingEnabled = true;
            this.comboUnvan.Items.AddRange(new object[] {
            "Kurul Başkanı ",
            "Kurul Üyesi",
            "Departman Müdürü",
            "Departman Şefi"});
            this.comboUnvan.Location = new System.Drawing.Point(238, 303);
            this.comboUnvan.Name = "comboUnvan";
            this.comboUnvan.Size = new System.Drawing.Size(298, 35);
            this.comboUnvan.TabIndex = 13;
            this.comboUnvan.Tag = "Unvan";
            // 
            // comboDepartman
            // 
            this.comboDepartman.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Items.AddRange(new object[] {
            "Yönetim",
            "İdari İşler",
            "Muhasebe",
            "Satın Alma",
            "Pazarlama",
            "Yazılım"});
            this.comboDepartman.Location = new System.Drawing.Point(238, 254);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(298, 35);
            this.comboDepartman.TabIndex = 13;
            this.comboDepartman.Tag = "Departman";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDogumTarihi.Location = new System.Drawing.Point(238, 206);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(298, 31);
            this.dateDogumTarihi.TabIndex = 12;
            this.dateDogumTarihi.Tag = "DogumTarihi";
            this.dateDogumTarihi.ValueChanged += new System.EventHandler(this.dateDogumTarihi_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Durum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Unvan";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Departman";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doğum Tarihi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPerNo
            // 
            this.textPerNo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPerNo.Location = new System.Drawing.Point(238, 157);
            this.textPerNo.MaxLength = 8;
            this.textPerNo.Name = "textPerNo";
            this.textPerNo.Size = new System.Drawing.Size(298, 34);
            this.textPerNo.TabIndex = 7;
            this.textPerNo.Tag = "PersonelNo";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTc
            // 
            this.textTc.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTc.Location = new System.Drawing.Point(238, 108);
            this.textTc.MaxLength = 11;
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(298, 34);
            this.textTc.TabIndex = 5;
            this.textTc.Tag = "TcKimlik";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tc Kimlik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textSoyadı
            // 
            this.textSoyadı.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyadı.Location = new System.Drawing.Point(238, 59);
            this.textSoyadı.Name = "textSoyadı";
            this.textSoyadı.Size = new System.Drawing.Size(298, 34);
            this.textSoyadı.TabIndex = 3;
            this.textSoyadı.Tag = "Soyad";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAdı
            // 
            this.textAdı.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdı.Location = new System.Drawing.Point(238, 10);
            this.textAdı.Name = "textAdı";
            this.textAdı.Size = new System.Drawing.Size(298, 34);
            this.textAdı.TabIndex = 1;
            this.textAdı.Tag = "Ad";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.btnHepsiniSil);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Location = new System.Drawing.Point(8, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 96);
            this.panel1.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(603, 16);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(170, 66);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(1207, 16);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(170, 66);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(1012, 16);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(170, 66);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(807, 16);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(170, 66);
            this.btnHepsiniSil.TabIndex = 0;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(400, 16);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 66);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "SEÇİLİ KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(201, 16);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(170, 66);
            this.btnGüncelle.TabIndex = 0;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(3, 16);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 66);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(591, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 406);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmAnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1403, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAraçlar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip ";
            this.Load += new System.EventHandler(this.FrmAnaMenü_Load);
            this.panelAraçlar.ResumeLayout(false);
            this.panelAraçlar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAraçlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPerNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSoyadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.ComboBox comboUnvan;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}