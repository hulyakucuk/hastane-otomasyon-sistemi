namespace hastane_otomasyon
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.button_hasta = new System.Windows.Forms.Button();
            this.button_doktor = new System.Windows.Forms.Button();
            this.button_randevu = new System.Windows.Forms.Button();
            this.button_klinik = new System.Windows.Forms.Button();
            this.button_recete = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_hasta
            // 
            this.button_hasta.Location = new System.Drawing.Point(26, 75);
            this.button_hasta.Name = "button_hasta";
            this.button_hasta.Size = new System.Drawing.Size(190, 89);
            this.button_hasta.TabIndex = 0;
            this.button_hasta.Text = "HASTA";
            this.button_hasta.UseVisualStyleBackColor = true;
            this.button_hasta.Click += new System.EventHandler(this.button_hasta_Click);
            // 
            // button_doktor
            // 
            this.button_doktor.Location = new System.Drawing.Point(26, 209);
            this.button_doktor.Name = "button_doktor";
            this.button_doktor.Size = new System.Drawing.Size(190, 89);
            this.button_doktor.TabIndex = 1;
            this.button_doktor.Text = "DOKTOR";
            this.button_doktor.UseVisualStyleBackColor = true;
            // 
            // button_randevu
            // 
            this.button_randevu.Location = new System.Drawing.Point(26, 347);
            this.button_randevu.Name = "button_randevu";
            this.button_randevu.Size = new System.Drawing.Size(190, 89);
            this.button_randevu.TabIndex = 2;
            this.button_randevu.Text = "RANDEVULAR";
            this.button_randevu.UseVisualStyleBackColor = true;
            // 
            // button_klinik
            // 
            this.button_klinik.Location = new System.Drawing.Point(697, 75);
            this.button_klinik.Name = "button_klinik";
            this.button_klinik.Size = new System.Drawing.Size(190, 89);
            this.button_klinik.TabIndex = 3;
            this.button_klinik.Text = "KLİNİKLER";
            this.button_klinik.UseVisualStyleBackColor = true;
            // 
            // button_recete
            // 
            this.button_recete.Location = new System.Drawing.Point(697, 209);
            this.button_recete.Name = "button_recete";
            this.button_recete.Size = new System.Drawing.Size(190, 89);
            this.button_recete.TabIndex = 4;
            this.button_recete.Text = "REÇETELER";
            this.button_recete.UseVisualStyleBackColor = true;
            this.button_recete.Click += new System.EventHandler(this.button_recete_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(697, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 89);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(26, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Padding = new System.Windows.Forms.Padding(8);
            this.button_geri.Size = new System.Drawing.Size(90, 57);
            this.button_geri.TabIndex = 6;
            this.button_geri.Text = "geri";
            this.button_geri.UseMnemonic = false;
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(914, 585);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_recete);
            this.Controls.Add(this.button_klinik);
            this.Controls.Add(this.button_randevu);
            this.Controls.Add(this.button_doktor);
            this.Controls.Add(this.button_hasta);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_hasta;
        private System.Windows.Forms.Button button_doktor;
        private System.Windows.Forms.Button button_randevu;
        private System.Windows.Forms.Button button_klinik;
        private System.Windows.Forms.Button button_recete;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_geri;
    }
}