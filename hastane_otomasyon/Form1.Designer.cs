namespace hastane_otomasyon
{
    partial class Form1
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
            this.button_giris = new System.Windows.Forms.Button();
            this.button_cikis = new System.Windows.Forms.Button();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(108, 264);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(88, 62);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "GİRİŞ";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // button_cikis
            // 
            this.button_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cikis.Location = new System.Drawing.Point(231, 264);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(88, 62);
            this.button_cikis.TabIndex = 1;
            this.button_cikis.Text = "ÇIKIŞ";
            this.button_cikis.UseVisualStyleBackColor = true;
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ad.Location = new System.Drawing.Point(63, 96);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(130, 25);
            this.label_ad.TabIndex = 2;
            this.label_ad.Text = "Kullanıcı Adı: ";
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.Location = new System.Drawing.Point(63, 170);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(79, 25);
            this.label_parola.TabIndex = 3;
            this.label_parola.Text = "Parola: ";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(245, 96);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(124, 22);
            this.textBox_ad.TabIndex = 4;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(245, 170);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(124, 22);
            this.textBox_parola.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 406);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.button_cikis);
            this.Controls.Add(this.button_giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_parola;
    }
}

