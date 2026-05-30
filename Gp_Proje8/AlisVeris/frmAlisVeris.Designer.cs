
namespace AlisVeris
{
    partial class frmAlisVeris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMusteri = new System.Windows.Forms.PictureBox();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMusteriler = new System.Windows.Forms.DataGridView();
            this.txtMusteriTelefonu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSiparisID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgSepet = new System.Windows.Forms.DataGridView();
            this.dgSiparisler = new System.Windows.Forms.DataGridView();
            this.cbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSiparisSil = new FontAwesome.Sharp.IconButton();
            this.btnYeniSiparis = new FontAwesome.Sharp.IconButton();
            this.btnKapat = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbUrun = new System.Windows.Forms.PictureBox();
            this.txtUrunAlisFiyati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteriler)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiparisler)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMusteriID);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pbMusteri);
            this.groupBox1.Controls.Add(this.txtMusteriAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgMusteriler);
            this.groupBox1.Controls.Add(this.txtMusteriTelefonu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMusteriSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMusteriAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Seç";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(159, 487);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(63, 22);
            this.txtMusteriID.TabIndex = 13;
            this.txtMusteriID.Visible = false;
            this.txtMusteriID.TextChanged += new System.EventHandler(this.txtMusteriID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(23, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 1);
            this.panel1.TabIndex = 12;
            // 
            // pbMusteri
            // 
            this.pbMusteri.BackColor = System.Drawing.Color.DarkGray;
            this.pbMusteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMusteri.Location = new System.Drawing.Point(97, 155);
            this.pbMusteri.Name = "pbMusteri";
            this.pbMusteri.Size = new System.Drawing.Size(159, 172);
            this.pbMusteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusteri.TabIndex = 11;
            this.pbMusteri.TabStop = false;
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAra.Location = new System.Drawing.Point(90, 376);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(166, 22);
            this.txtMusteriAra.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ara:";
            // 
            // dgMusteriler
            // 
            this.dgMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteriler.GridColor = System.Drawing.Color.White;
            this.dgMusteriler.Location = new System.Drawing.Point(8, 413);
            this.dgMusteriler.Name = "dgMusteriler";
            this.dgMusteriler.ReadOnly = true;
            this.dgMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMusteriler.Size = new System.Drawing.Size(256, 169);
            this.dgMusteriler.TabIndex = 8;
            this.dgMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMusteriler_CellClick);
            // 
            // txtMusteriTelefonu
            // 
            this.txtMusteriTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTelefonu.Location = new System.Drawing.Point(97, 114);
            this.txtMusteriTelefonu.Name = "txtMusteriTelefonu";
            this.txtMusteriTelefonu.ReadOnly = true;
            this.txtMusteriTelefonu.Size = new System.Drawing.Size(159, 22);
            this.txtMusteriTelefonu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefonu:";
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(97, 74);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.ReadOnly = true;
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(159, 22);
            this.txtMusteriSoyadi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı:";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.Location = new System.Drawing.Point(97, 34);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.ReadOnly = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(159, 22);
            this.txtMusteriAdi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSiparisID);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.dgSepet);
            this.groupBox2.Controls.Add(this.dgSiparisler);
            this.groupBox2.Controls.Add(this.cbOdemeTuru);
            this.groupBox2.Controls.Add(this.dtpSiparisTarihi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSiparisSil);
            this.groupBox2.Controls.Add(this.btnYeniSiparis);
            this.groupBox2.Controls.Add(this.btnKapat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(302, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 592);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Bilgileri";
            // 
            // txtSiparisID
            // 
            this.txtSiparisID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparisID.Location = new System.Drawing.Point(500, 21);
            this.txtSiparisID.Name = "txtSiparisID";
            this.txtSiparisID.Size = new System.Drawing.Size(63, 22);
            this.txtSiparisID.TabIndex = 22;
            this.txtSiparisID.Visible = false;
            this.txtSiparisID.TextChanged += new System.EventHandler(this.txtSiparisID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(68, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 1);
            this.panel3.TabIndex = 21;
            // 
            // dgSepet
            // 
            this.dgSepet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSepet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgSepet.Location = new System.Drawing.Point(135, 331);
            this.dgSepet.Name = "dgSepet";
            this.dgSepet.ReadOnly = true;
            this.dgSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSepet.Size = new System.Drawing.Size(428, 251);
            this.dgSepet.TabIndex = 20;
            // 
            // dgSiparisler
            // 
            this.dgSiparisler.BackgroundColor = System.Drawing.Color.White;
            this.dgSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiparisler.GridColor = System.Drawing.Color.White;
            this.dgSiparisler.Location = new System.Drawing.Point(288, 53);
            this.dgSiparisler.Name = "dgSiparisler";
            this.dgSiparisler.ReadOnly = true;
            this.dgSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSiparisler.Size = new System.Drawing.Size(275, 200);
            this.dgSiparisler.TabIndex = 20;
            this.dgSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSiparisler_CellClick);
            // 
            // cbOdemeTuru
            // 
            this.cbOdemeTuru.FormattingEnabled = true;
            this.cbOdemeTuru.Items.AddRange(new object[] {
            "Peşin",
            "Taksit",
            "Kredi Kartı"});
            this.cbOdemeTuru.Location = new System.Drawing.Point(135, 98);
            this.cbOdemeTuru.Name = "cbOdemeTuru";
            this.cbOdemeTuru.Size = new System.Drawing.Size(138, 24);
            this.cbOdemeTuru.TabIndex = 19;
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(135, 62);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(138, 22);
            this.dtpSiparisTarihi.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(285, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Sepet İçeriği:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(39, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ödeme Türü:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(285, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Müşteri Siparişleri:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(39, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sipariş Tarihi:";
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.FlatAppearance.BorderSize = 0;
            this.btnSiparisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisSil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSiparisSil.IconColor = System.Drawing.Color.Black;
            this.btnSiparisSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiparisSil.Location = new System.Drawing.Point(145, 188);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(128, 49);
            this.btnSiparisSil.TabIndex = 16;
            this.btnSiparisSil.Text = "Sipariş Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            // 
            // btnYeniSiparis
            // 
            this.btnYeniSiparis.FlatAppearance.BorderSize = 0;
            this.btnYeniSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniSiparis.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnYeniSiparis.IconColor = System.Drawing.Color.Black;
            this.btnYeniSiparis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYeniSiparis.Location = new System.Drawing.Point(13, 188);
            this.btnYeniSiparis.Name = "btnYeniSiparis";
            this.btnYeniSiparis.Size = new System.Drawing.Size(128, 49);
            this.btnYeniSiparis.TabIndex = 16;
            this.btnYeniSiparis.Text = "Yeni Sipariş";
            this.btnYeniSiparis.UseVisualStyleBackColor = true;
            this.btnYeniSiparis.Click += new System.EventHandler(this.btnYeniSiparis_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnKapat.IconColor = System.Drawing.Color.Black;
            this.btnKapat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKapat.Location = new System.Drawing.Point(13, 518);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(128, 64);
            this.btnKapat.TabIndex = 16;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSatisFiyati);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtUrunID);
            this.groupBox3.Controls.Add(this.btnUrunEkle);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.dgUrunler);
            this.groupBox3.Controls.Add(this.txtUrunAra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.pbUrun);
            this.groupBox3.Controls.Add(this.txtUrunAlisFiyati);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUrunAdi);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUrunKodu);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(891, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 592);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Seçme";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(179, 487);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(63, 22);
            this.txtUrunID.TabIndex = 16;
            this.txtUrunID.Visible = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUrunEkle.IconColor = System.Drawing.Color.Black;
            this.btnUrunEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUrunEkle.Location = new System.Drawing.Point(11, 399);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(250, 49);
            this.btnUrunEkle.TabIndex = 15;
            this.btnUrunEkle.Text = "Seçilen Ürünü Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(25, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 1);
            this.panel2.TabIndex = 14;
            // 
            // dgUrunler
            // 
            this.dgUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgUrunler.Location = new System.Drawing.Point(10, 454);
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.ReadOnly = true;
            this.dgUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUrunler.Size = new System.Drawing.Size(250, 128);
            this.dgUrunler.TabIndex = 13;
            this.dgUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUrunler_CellClick);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAra.Location = new System.Drawing.Point(102, 36);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(159, 22);
            this.txtUrunAra.TabIndex = 12;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(57, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ara:";
            // 
            // pbUrun
            // 
            this.pbUrun.BackColor = System.Drawing.Color.DarkGray;
            this.pbUrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrun.Location = new System.Drawing.Point(102, 188);
            this.pbUrun.Name = "pbUrun";
            this.pbUrun.Size = new System.Drawing.Size(159, 172);
            this.pbUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrun.TabIndex = 10;
            this.pbUrun.TabStop = false;
            // 
            // txtUrunAlisFiyati
            // 
            this.txtUrunAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAlisFiyati.Location = new System.Drawing.Point(102, 157);
            this.txtUrunAlisFiyati.Name = "txtUrunAlisFiyati";
            this.txtUrunAlisFiyati.ReadOnly = true;
            this.txtUrunAlisFiyati.Size = new System.Drawing.Size(159, 22);
            this.txtUrunAlisFiyati.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(102, 121);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(159, 22);
            this.txtUrunAdi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adı:";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Location = new System.Drawing.Point(102, 85);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.ReadOnly = true;
            this.txtUrunKodu.Size = new System.Drawing.Size(159, 22);
            this.txtUrunKodu.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kodu:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati.Location = new System.Drawing.Point(101, 371);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.ReadOnly = true;
            this.txtSatisFiyati.Size = new System.Drawing.Size(159, 22);
            this.txtSatisFiyati.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(21, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Satış Fiyatı:";
            // 
            // frmAlisVeris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1181, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlisVeris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlisVeris";
            this.Load += new System.EventHandler(this.frmAlisVeris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteriler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiparisler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMusteriTelefonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMusteriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMusteri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbUrun;
        private System.Windows.Forms.TextBox txtUrunAlisFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgUrunler;
        private FontAwesome.Sharp.IconButton btnSiparisSil;
        private FontAwesome.Sharp.IconButton btnYeniSiparis;
        private FontAwesome.Sharp.IconButton btnKapat;
        private FontAwesome.Sharp.IconButton btnUrunEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgSepet;
        private System.Windows.Forms.DataGridView dgSiparisler;
        private System.Windows.Forms.ComboBox cbOdemeTuru;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtSiparisID;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label13;
    }
}