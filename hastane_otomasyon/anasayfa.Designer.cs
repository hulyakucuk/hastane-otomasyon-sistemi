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
            this.button_doktor = new System.Windows.Forms.Button();
            this.button_hasta_ekle = new System.Windows.Forms.Button();
            this.button_randevular = new System.Windows.Forms.Button();
            this.button_recete = new System.Windows.Forms.Button();
            this.button_klinikler = new System.Windows.Forms.Button();
            this.button_hasta_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_doktor
            // 
            this.button_doktor.Location = new System.Drawing.Point(50, 29);
            this.button_doktor.Name = "button_doktor";
            this.button_doktor.Size = new System.Drawing.Size(183, 95);
            this.button_doktor.TabIndex = 0;
            this.button_doktor.Text = "DOKTOR-EKLE";
            this.button_doktor.UseVisualStyleBackColor = true;
            this.button_doktor.Click += new System.EventHandler(this.button_doktor_Click);
            // 
            // button_hasta_ekle
            // 
            this.button_hasta_ekle.Location = new System.Drawing.Point(50, 158);
            this.button_hasta_ekle.Name = "button_hasta_ekle";
            this.button_hasta_ekle.Size = new System.Drawing.Size(183, 95);
            this.button_hasta_ekle.TabIndex = 1;
            this.button_hasta_ekle.Text = "HASTA-EKLE";
            this.button_hasta_ekle.UseVisualStyleBackColor = true;
            this.button_hasta_ekle.Click += new System.EventHandler(this.button_hasta_ekle_Click);
            // 
            // button_randevular
            // 
            this.button_randevular.Location = new System.Drawing.Point(50, 294);
            this.button_randevular.Name = "button_randevular";
            this.button_randevular.Size = new System.Drawing.Size(183, 95);
            this.button_randevular.TabIndex = 2;
            this.button_randevular.Text = "RANDEVULAR";
            this.button_randevular.UseVisualStyleBackColor = true;
            this.button_randevular.Click += new System.EventHandler(this.button_randevular_Click);
            // 
            // button_recete
            // 
            this.button_recete.Location = new System.Drawing.Point(576, 29);
            this.button_recete.Name = "button_recete";
            this.button_recete.Size = new System.Drawing.Size(183, 95);
            this.button_recete.TabIndex = 3;
            this.button_recete.Text = "REÇETELER";
            this.button_recete.UseVisualStyleBackColor = true;
            this.button_recete.Click += new System.EventHandler(this.button_recete_Click);
            // 
            // button_klinikler
            // 
            this.button_klinikler.Location = new System.Drawing.Point(576, 158);
            this.button_klinikler.Name = "button_klinikler";
            this.button_klinikler.Size = new System.Drawing.Size(183, 95);
            this.button_klinikler.TabIndex = 4;
            this.button_klinikler.Text = "KLİNİKLER";
            this.button_klinikler.UseVisualStyleBackColor = true;
            this.button_klinikler.Click += new System.EventHandler(this.button_klinikler_Click);
            // 
            // button_hasta_sil
            // 
            this.button_hasta_sil.Location = new System.Drawing.Point(576, 294);
            this.button_hasta_sil.Name = "button_hasta_sil";
            this.button_hasta_sil.Size = new System.Drawing.Size(183, 95);
            this.button_hasta_sil.TabIndex = 5;
            this.button_hasta_sil.Text = "HASTA-SİL";
            this.button_hasta_sil.UseVisualStyleBackColor = true;
            this.button_hasta_sil.Click += new System.EventHandler(this.button_hasta_sil_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_hasta_sil);
            this.Controls.Add(this.button_klinikler);
            this.Controls.Add(this.button_recete);
            this.Controls.Add(this.button_randevular);
            this.Controls.Add(this.button_hasta_ekle);
            this.Controls.Add(this.button_doktor);
            this.DoubleBuffered = true;
            this.Name = "anasayfa";
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_doktor;
        private System.Windows.Forms.Button button_hasta_ekle;
        private System.Windows.Forms.Button button_randevular;
        private System.Windows.Forms.Button button_recete;
        private System.Windows.Forms.Button button_klinikler;
        private System.Windows.Forms.Button button_hasta_sil;
    }
}