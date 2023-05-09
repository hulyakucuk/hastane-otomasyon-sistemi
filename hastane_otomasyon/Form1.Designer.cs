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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_doktor = new System.Windows.Forms.Button();
            this.button_hasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_doktor
            // 
            this.button_doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_doktor.Location = new System.Drawing.Point(40, 162);
            this.button_doktor.Name = "button_doktor";
            this.button_doktor.Size = new System.Drawing.Size(141, 129);
            this.button_doktor.TabIndex = 0;
            this.button_doktor.Text = "Doktor Girişi";
            this.button_doktor.UseVisualStyleBackColor = true;
            this.button_doktor.Click += new System.EventHandler(this.button_doktor_Click);
            // 
            // button_hasta
            // 
            this.button_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hasta.Location = new System.Drawing.Point(388, 162);
            this.button_hasta.Name = "button_hasta";
            this.button_hasta.Size = new System.Drawing.Size(141, 129);
            this.button_hasta.TabIndex = 1;
            this.button_hasta.Text = "Hasta Girişi";
            this.button_hasta.UseVisualStyleBackColor = true;
            this.button_hasta.Click += new System.EventHandler(this.button_hasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(569, 478);
            this.Controls.Add(this.button_hasta);
            this.Controls.Add(this.button_doktor);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_doktor;
        private System.Windows.Forms.Button button_hasta;
    }
}

