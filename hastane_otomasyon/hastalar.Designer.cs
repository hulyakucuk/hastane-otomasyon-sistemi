namespace hastane_otomasyon
{
    partial class hastalar
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
            this.dataGridView_hastalar = new System.Windows.Forms.DataGridView();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_cinsiyet = new System.Windows.Forms.TextBox();
            this.textBox_tc_no = new System.Windows.Forms.TextBox();
            this.label_cinsiyet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_tc_no = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_kan_grubu = new System.Windows.Forms.Label();
            this.comboBox_kan_grubu = new System.Windows.Forms.ComboBox();
            this.textBox_tel_no = new System.Windows.Forms.TextBox();
            this.label_tel_no = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_hastalar
            // 
            this.dataGridView_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hastalar.Location = new System.Drawing.Point(23, 12);
            this.dataGridView_hastalar.Name = "dataGridView_hastalar";
            this.dataGridView_hastalar.RowHeadersWidth = 51;
            this.dataGridView_hastalar.RowTemplate.Height = 24;
            this.dataGridView_hastalar.Size = new System.Drawing.Size(920, 342);
            this.dataGridView_hastalar.TabIndex = 0;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(839, 370);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(104, 35);
            this.button_ekle.TabIndex = 1;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(839, 420);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(104, 35);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(839, 472);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(104, 35);
            this.button_guncelle.TabIndex = 3;
            this.button_guncelle.Text = "GÜNCELLE";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(24, 376);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(63, 16);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "Hasta id: ";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(116, 376);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(577, 370);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(121, 22);
            this.textBox_soyad.TabIndex = 6;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(325, 373);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 22);
            this.textBox_ad.TabIndex = 8;
            // 
            // textBox_cinsiyet
            // 
            this.textBox_cinsiyet.Location = new System.Drawing.Point(116, 433);
            this.textBox_cinsiyet.Name = "textBox_cinsiyet";
            this.textBox_cinsiyet.Size = new System.Drawing.Size(100, 22);
            this.textBox_cinsiyet.TabIndex = 9;
            // 
            // textBox_tc_no
            // 
            this.textBox_tc_no.Location = new System.Drawing.Point(325, 430);
            this.textBox_tc_no.Name = "textBox_tc_no";
            this.textBox_tc_no.Size = new System.Drawing.Size(100, 22);
            this.textBox_tc_no.TabIndex = 10;
            // 
            // label_cinsiyet
            // 
            this.label_cinsiyet.AutoSize = true;
            this.label_cinsiyet.Location = new System.Drawing.Point(24, 436);
            this.label_cinsiyet.Name = "label_cinsiyet";
            this.label_cinsiyet.Size = new System.Drawing.Size(60, 16);
            this.label_cinsiyet.TabIndex = 11;
            this.label_cinsiyet.Text = "Cinsiyet: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hasta Adı: ";
            // 
            // label_tc_no
            // 
            this.label_tc_no.AutoSize = true;
            this.label_tc_no.Location = new System.Drawing.Point(242, 433);
            this.label_tc_no.Name = "label_tc_no";
            this.label_tc_no.Size = new System.Drawing.Size(49, 16);
            this.label_tc_no.TabIndex = 13;
            this.label_tc_no.Text = "TC No:";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(451, 376);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(95, 16);
            this.label_soyad.TabIndex = 14;
            this.label_soyad.Text = "Hasta Soyadı: ";
            // 
            // label_kan_grubu
            // 
            this.label_kan_grubu.AutoSize = true;
            this.label_kan_grubu.Location = new System.Drawing.Point(451, 436);
            this.label_kan_grubu.Name = "label_kan_grubu";
            this.label_kan_grubu.Size = new System.Drawing.Size(75, 16);
            this.label_kan_grubu.TabIndex = 15;
            this.label_kan_grubu.Text = "Kan Grubu: ";
            // 
            // comboBox_kan_grubu
            // 
            this.comboBox_kan_grubu.FormattingEnabled = true;
            this.comboBox_kan_grubu.Location = new System.Drawing.Point(577, 431);
            this.comboBox_kan_grubu.Name = "comboBox_kan_grubu";
            this.comboBox_kan_grubu.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kan_grubu.TabIndex = 16;
            // 
            // textBox_tel_no
            // 
            this.textBox_tel_no.Location = new System.Drawing.Point(116, 485);
            this.textBox_tel_no.Name = "textBox_tel_no";
            this.textBox_tel_no.Size = new System.Drawing.Size(100, 22);
            this.textBox_tel_no.TabIndex = 17;
            // 
            // label_tel_no
            // 
            this.label_tel_no.AutoSize = true;
            this.label_tel_no.Location = new System.Drawing.Point(27, 485);
            this.label_tel_no.Name = "label_tel_no";
            this.label_tel_no.Size = new System.Drawing.Size(51, 16);
            this.label_tel_no.TabIndex = 18;
            this.label_tel_no.Text = "Tel No:";
            // 
            // hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.label_tel_no);
            this.Controls.Add(this.textBox_tel_no);
            this.Controls.Add(this.comboBox_kan_grubu);
            this.Controls.Add(this.label_kan_grubu);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.label_tc_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_cinsiyet);
            this.Controls.Add(this.textBox_tc_no);
            this.Controls.Add(this.textBox_cinsiyet);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.dataGridView_hastalar);
            this.Name = "hastalar";
            this.Text = "hastalar";
            this.Load += new System.EventHandler(this.hastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_hastalar;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_tc_no;
        private System.Windows.Forms.Label label_cinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_tc_no;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_kan_grubu;
        private System.Windows.Forms.ComboBox comboBox_kan_grubu;
        private System.Windows.Forms.TextBox textBox_tel_no;
        private System.Windows.Forms.Label label_tel_no;
    }
}