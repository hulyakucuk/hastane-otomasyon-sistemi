namespace hastane_otomasyon
{
    partial class klinik
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
            this.button_geri = new System.Windows.Forms.Button();
            this.button_getir = new System.Windows.Forms.Button();
            this.textBox_klinik_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_klinikler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_klinikler)).BeginInit();
            this.SuspendLayout();
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(10, 17);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(60, 46);
            this.button_geri.TabIndex = 14;
            this.button_geri.Text = "geri";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // button_getir
            // 
            this.button_getir.Location = new System.Drawing.Point(334, 250);
            this.button_getir.Name = "button_getir";
            this.button_getir.Size = new System.Drawing.Size(75, 40);
            this.button_getir.TabIndex = 13;
            this.button_getir.Text = "GETİR";
            this.button_getir.UseVisualStyleBackColor = true;
            this.button_getir.Click += new System.EventHandler(this.button_getir_Click);
            // 
            // textBox_klinik_ad
            // 
            this.textBox_klinik_ad.Location = new System.Drawing.Point(201, 259);
            this.textBox_klinik_ad.Name = "textBox_klinik_ad";
            this.textBox_klinik_ad.Size = new System.Drawing.Size(100, 22);
            this.textBox_klinik_ad.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Klinik Adı:";
            // 
            // dataGridView_klinikler
            // 
            this.dataGridView_klinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_klinikler.Location = new System.Drawing.Point(76, 17);
            this.dataGridView_klinikler.Name = "dataGridView_klinikler";
            this.dataGridView_klinikler.RowHeadersWidth = 51;
            this.dataGridView_klinikler.RowTemplate.Height = 24;
            this.dataGridView_klinikler.Size = new System.Drawing.Size(388, 199);
            this.dataGridView_klinikler.TabIndex = 10;
            // 
            // klinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 335);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button_getir);
            this.Controls.Add(this.textBox_klinik_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_klinikler);
            this.Name = "klinik";
            this.Text = "klinik";
            this.Load += new System.EventHandler(this.klinik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_klinikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Button button_getir;
        private System.Windows.Forms.TextBox textBox_klinik_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_klinikler;
    }
}