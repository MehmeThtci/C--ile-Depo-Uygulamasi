namespace proje
{
    partial class calışanform
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
            this.btn_sil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textbox_calisansoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.textbox_calisanad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridcalışanlar = new System.Windows.Forms.DataGridView();
            this.textbox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.cb_ilce = new System.Windows.Forms.ComboBox();
            this.textbox_calisantelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_sifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_gorev = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.text_calisanid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.text_adresid = new System.Windows.Forms.TextBox();
            this.datagridanacalışanlar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcalışanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridanacalışanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DarkRed;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(536, 422);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(130, 28);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(536, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "KAPAT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textbox_calisansoyad
            // 
            this.textbox_calisansoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textbox_calisansoyad.ForeColor = System.Drawing.Color.White;
            this.textbox_calisansoyad.Location = new System.Drawing.Point(191, 330);
            this.textbox_calisansoyad.Name = "textbox_calisansoyad";
            this.textbox_calisansoyad.Size = new System.Drawing.Size(163, 20);
            this.textbox_calisansoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "ÇALIŞAN TELEFONU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "ÇALIŞAN ADRESİ:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(387, 422);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(130, 28);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // textbox_calisanad
            // 
            this.textbox_calisanad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textbox_calisanad.ForeColor = System.Drawing.Color.White;
            this.textbox_calisanad.Location = new System.Drawing.Point(191, 293);
            this.textbox_calisanad.Name = "textbox_calisanad";
            this.textbox_calisanad.Size = new System.Drawing.Size(163, 20);
            this.textbox_calisanad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "ÇALIŞAN ADI:";
            // 
            // datagridcalışanlar
            // 
            this.datagridcalışanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcalışanlar.Location = new System.Drawing.Point(12, 12);
            this.datagridcalışanlar.Name = "datagridcalışanlar";
            this.datagridcalışanlar.ReadOnly = true;
            this.datagridcalışanlar.Size = new System.Drawing.Size(1035, 255);
            this.datagridcalışanlar.TabIndex = 86;
            this.datagridcalışanlar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagridcalışanlar_CellFormatting);
            this.datagridcalışanlar.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridcalışanlar_EditingControlShowing);
            this.datagridcalışanlar.Click += new System.EventHandler(this.datagridcalışanlar_Click);
            // 
            // textbox_kullaniciadi
            // 
            this.textbox_kullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textbox_kullaniciadi.ForeColor = System.Drawing.Color.White;
            this.textbox_kullaniciadi.Location = new System.Drawing.Point(16, 462);
            this.textbox_kullaniciadi.Name = "textbox_kullaniciadi";
            this.textbox_kullaniciadi.Size = new System.Drawing.Size(163, 20);
            this.textbox_kullaniciadi.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "ÇALIŞAN GÖREVİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "ÇALIŞAN SOYADI:";
            // 
            // cb_sehir
            // 
            this.cb_sehir.BackColor = System.Drawing.Color.White;
            this.cb_sehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Items.AddRange(new object[] {
            "-"});
            this.cb_sehir.Location = new System.Drawing.Point(536, 291);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(163, 26);
            this.cb_sehir.TabIndex = 99;
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.cb_sehir_SelectedIndexChanged);
            // 
            // cb_ilce
            // 
            this.cb_ilce.BackColor = System.Drawing.Color.White;
            this.cb_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ilce.FormattingEnabled = true;
            this.cb_ilce.Items.AddRange(new object[] {
            "-"});
            this.cb_ilce.Location = new System.Drawing.Point(721, 291);
            this.cb_ilce.Name = "cb_ilce";
            this.cb_ilce.Size = new System.Drawing.Size(163, 26);
            this.cb_ilce.TabIndex = 100;
            // 
            // textbox_calisantelefon
            // 
            this.textbox_calisantelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textbox_calisantelefon.ForeColor = System.Drawing.Color.White;
            this.textbox_calisantelefon.Location = new System.Drawing.Point(191, 403);
            this.textbox_calisantelefon.Name = "textbox_calisantelefon";
            this.textbox_calisantelefon.Size = new System.Drawing.Size(163, 20);
            this.textbox_calisantelefon.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "KULLANICI ADI";
            // 
            // textbox_sifre
            // 
            this.textbox_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textbox_sifre.ForeColor = System.Drawing.Color.White;
            this.textbox_sifre.Location = new System.Drawing.Point(194, 462);
            this.textbox_sifre.Name = "textbox_sifre";
            this.textbox_sifre.Size = new System.Drawing.Size(163, 20);
            this.textbox_sifre.TabIndex = 101;
            this.textbox_sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_sifre_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(190, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "ŞİFRE";
            // 
            // cb_gorev
            // 
            this.cb_gorev.BackColor = System.Drawing.Color.White;
            this.cb_gorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_gorev.FormattingEnabled = true;
            this.cb_gorev.Items.AddRange(new object[] {
            "-"});
            this.cb_gorev.Location = new System.Drawing.Point(191, 364);
            this.cb_gorev.Name = "cb_gorev";
            this.cb_gorev.Size = new System.Drawing.Size(163, 26);
            this.cb_gorev.TabIndex = 105;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.Location = new System.Drawing.Point(536, 328);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 57);
            this.richTextBox1.TabIndex = 106;
            this.richTextBox1.Text = "LÜTFEN ADRES DETAYINI GİRİNİZ:";
            this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btn_güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_güncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_güncelle.ForeColor = System.Drawing.Color.White;
            this.btn_güncelle.Location = new System.Drawing.Point(387, 376);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(130, 28);
            this.btn_güncelle.TabIndex = 107;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // text_calisanid
            // 
            this.text_calisanid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.text_calisanid.ForeColor = System.Drawing.Color.White;
            this.text_calisanid.Location = new System.Drawing.Point(16, 273);
            this.text_calisanid.Name = "text_calisanid";
            this.text_calisanid.Size = new System.Drawing.Size(15, 20);
            this.text_calisanid.TabIndex = 108;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(387, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "LİSTELE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_adresid
            // 
            this.text_adresid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.text_adresid.ForeColor = System.Drawing.Color.White;
            this.text_adresid.Location = new System.Drawing.Point(1031, 481);
            this.text_adresid.Name = "text_adresid";
            this.text_adresid.Size = new System.Drawing.Size(15, 20);
            this.text_adresid.TabIndex = 109;
            this.text_adresid.Visible = false;
            // 
            // datagridanacalışanlar
            // 
            this.datagridanacalışanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridanacalışanlar.Location = new System.Drawing.Point(1011, 491);
            this.datagridanacalışanlar.Name = "datagridanacalışanlar";
            this.datagridanacalışanlar.Size = new System.Drawing.Size(14, 10);
            this.datagridanacalışanlar.TabIndex = 110;
            this.datagridanacalışanlar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(976, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // calışanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1058, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridanacalışanlar);
            this.Controls.Add(this.text_adresid);
            this.Controls.Add(this.text_calisanid);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cb_gorev);
            this.Controls.Add(this.textbox_calisantelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_sifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_ilce);
            this.Controls.Add(this.cb_sehir);
            this.Controls.Add(this.textbox_kullaniciadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textbox_calisansoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.textbox_calisanad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridcalışanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "calışanform";
            this.Text = "calışanform";
            ((System.ComponentModel.ISupportInitialize)(this.datagridcalışanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridanacalışanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textbox_calisansoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox textbox_calisanad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridcalışanlar;
        private System.Windows.Forms.TextBox textbox_kullaniciadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.ComboBox cb_ilce;
        private System.Windows.Forms.TextBox textbox_calisantelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_sifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_gorev;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.TextBox text_calisanid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_adresid;
        private System.Windows.Forms.DataGridView datagridanacalışanlar;
        private System.Windows.Forms.Label label2;
    }
}