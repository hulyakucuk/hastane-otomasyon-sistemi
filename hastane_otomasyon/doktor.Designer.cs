namespace hastane_otomasyon
{
    partial class doktor
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
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_geri = new System.Windows.Forms.Button();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_yetki_id = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.dataGridView_doktor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doktor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(375, 451);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(100, 22);
            this.textBox_parola.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Parola";
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(12, 6);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 44);
            this.button_geri.TabIndex = 42;
            this.button_geri.Text = "geri";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(561, 382);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(100, 22);
            this.textBox_soyad.TabIndex = 41;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(364, 382);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(106, 22);
            this.textBox_ad.TabIndex = 40;
            // 
            // textBox_yetki_id
            // 
            this.textBox_yetki_id.Location = new System.Drawing.Point(167, 451);
            this.textBox_yetki_id.Name = "textBox_yetki_id";
            this.textBox_yetki_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_yetki_id.TabIndex = 39;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(167, 382);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Yetki id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "İd:";
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(667, 446);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(106, 57);
            this.button_sil.TabIndex = 33;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(667, 362);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(106, 63);
            this.button_ekle.TabIndex = 32;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // dataGridView_doktor
            // 
            this.dataGridView_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doktor.Location = new System.Drawing.Point(105, 12);
            this.dataGridView_doktor.Name = "dataGridView_doktor";
            this.dataGridView_doktor.RowHeadersWidth = 51;
            this.dataGridView_doktor.RowTemplate.Height = 24;
            this.dataGridView_doktor.Size = new System.Drawing.Size(668, 338);
            this.dataGridView_doktor.TabIndex = 31;
            // 
            // doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 531);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.textBox_yetki_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.dataGridView_doktor);
            this.Name = "doktor";
            this.Text = "doktor";
            this.Load += new System.EventHandler(this.doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_yetki_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.DataGridView dataGridView_doktor;
    }
}