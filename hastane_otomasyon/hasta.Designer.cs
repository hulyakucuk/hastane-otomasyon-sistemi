namespace hastane_otomasyon
{
    partial class hasta
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
            this.textBox_yetki_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.Parola = new System.Windows.Forms.Label();
            this.button_geri = new System.Windows.Forms.Button();
            this.label_tel_no = new System.Windows.Forms.Label();
            this.textBox_tel_no = new System.Windows.Forms.TextBox();
            this.comboBox_kan_grubu = new System.Windows.Forms.ComboBox();
            this.label_kan_grubu = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_tc_no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cinsiyet = new System.Windows.Forms.Label();
            this.textBox_tc_no = new System.Windows.Forms.TextBox();
            this.textBox_cinsiyet = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_ekle = new System.Windows.Forms.Button();
            this.dataGridView_hastalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_yetki_id
            // 
            this.textBox_yetki_id.Location = new System.Drawing.Point(601, 473);
            this.textBox_yetki_id.Name = "textBox_yetki_id";
            this.textBox_yetki_id.Size = new System.Drawing.Size(121, 22);
            this.textBox_yetki_id.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Yetki id";
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(349, 479);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(100, 22);
            this.textBox_parola.TabIndex = 61;
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(269, 479);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(47, 16);
            this.Parola.TabIndex = 60;
            this.Parola.Text = "Parola";
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(15, 7);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(64, 45);
            this.button_geri.TabIndex = 59;
            this.button_geri.Text = "geri";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // label_tel_no
            // 
            this.label_tel_no.AutoSize = true;
            this.label_tel_no.Location = new System.Drawing.Point(51, 480);
            this.label_tel_no.Name = "label_tel_no";
            this.label_tel_no.Size = new System.Drawing.Size(51, 16);
            this.label_tel_no.TabIndex = 58;
            this.label_tel_no.Text = "Tel No:";
            // 
            // textBox_tel_no
            // 
            this.textBox_tel_no.Location = new System.Drawing.Point(140, 480);
            this.textBox_tel_no.Name = "textBox_tel_no";
            this.textBox_tel_no.Size = new System.Drawing.Size(100, 22);
            this.textBox_tel_no.TabIndex = 57;
            // 
            // comboBox_kan_grubu
            // 
            this.comboBox_kan_grubu.FormattingEnabled = true;
            this.comboBox_kan_grubu.Location = new System.Drawing.Point(601, 426);
            this.comboBox_kan_grubu.Name = "comboBox_kan_grubu";
            this.comboBox_kan_grubu.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kan_grubu.TabIndex = 56;
            // 
            // label_kan_grubu
            // 
            this.label_kan_grubu.AutoSize = true;
            this.label_kan_grubu.Location = new System.Drawing.Point(475, 431);
            this.label_kan_grubu.Name = "label_kan_grubu";
            this.label_kan_grubu.Size = new System.Drawing.Size(75, 16);
            this.label_kan_grubu.TabIndex = 55;
            this.label_kan_grubu.Text = "Kan Grubu: ";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(475, 371);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(95, 16);
            this.label_soyad.TabIndex = 54;
            this.label_soyad.Text = "Hasta Soyadı: ";
            // 
            // label_tc_no
            // 
            this.label_tc_no.AutoSize = true;
            this.label_tc_no.Location = new System.Drawing.Point(266, 428);
            this.label_tc_no.Name = "label_tc_no";
            this.label_tc_no.Size = new System.Drawing.Size(49, 16);
            this.label_tc_no.TabIndex = 53;
            this.label_tc_no.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hasta Adı: ";
            // 
            // label_cinsiyet
            // 
            this.label_cinsiyet.AutoSize = true;
            this.label_cinsiyet.Location = new System.Drawing.Point(48, 431);
            this.label_cinsiyet.Name = "label_cinsiyet";
            this.label_cinsiyet.Size = new System.Drawing.Size(60, 16);
            this.label_cinsiyet.TabIndex = 51;
            this.label_cinsiyet.Text = "Cinsiyet: ";
            // 
            // textBox_tc_no
            // 
            this.textBox_tc_no.Location = new System.Drawing.Point(349, 425);
            this.textBox_tc_no.Name = "textBox_tc_no";
            this.textBox_tc_no.Size = new System.Drawing.Size(100, 22);
            this.textBox_tc_no.TabIndex = 50;
            // 
            // textBox_cinsiyet
            // 
            this.textBox_cinsiyet.Location = new System.Drawing.Point(140, 428);
            this.textBox_cinsiyet.Name = "textBox_cinsiyet";
            this.textBox_cinsiyet.Size = new System.Drawing.Size(100, 22);
            this.textBox_cinsiyet.TabIndex = 49;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(349, 368);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 22);
            this.textBox_ad.TabIndex = 48;
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(601, 365);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(121, 22);
            this.textBox_soyad.TabIndex = 47;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(140, 371);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 46;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(48, 371);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(63, 16);
            this.label_id.TabIndex = 45;
            this.label_id.Text = "Hasta id: ";
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(785, 365);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(104, 66);
            this.button_ekle.TabIndex = 44;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // dataGridView_hastalar
            // 
            this.dataGridView_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hastalar.Location = new System.Drawing.Point(85, 7);
            this.dataGridView_hastalar.Name = "dataGridView_hastalar";
            this.dataGridView_hastalar.RowHeadersWidth = 51;
            this.dataGridView_hastalar.RowTemplate.Height = 24;
            this.dataGridView_hastalar.Size = new System.Drawing.Size(820, 313);
            this.dataGridView_hastalar.TabIndex = 43;
            // 
            // hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 532);
            this.Controls.Add(this.textBox_yetki_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.button_geri);
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
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.dataGridView_hastalar);
            this.Name = "hasta";
            this.Text = "hasta";
            this.Load += new System.EventHandler(this.hasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_yetki_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Label label_tel_no;
        private System.Windows.Forms.TextBox textBox_tel_no;
        private System.Windows.Forms.ComboBox comboBox_kan_grubu;
        private System.Windows.Forms.Label label_kan_grubu;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_tc_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_cinsiyet;
        private System.Windows.Forms.TextBox textBox_tc_no;
        private System.Windows.Forms.TextBox textBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.DataGridView dataGridView_hastalar;
    }
}