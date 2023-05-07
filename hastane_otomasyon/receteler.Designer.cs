namespace hastane_otomasyon
{
    partial class receteler
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
            this.dataGridView_recete = new System.Windows.Forms.DataGridView();
            this.button_hasta_ad_getir = new System.Windows.Forms.Button();
            this.label_hasta_adi = new System.Windows.Forms.Label();
            this.textBox_hasta_adi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_recete
            // 
            this.dataGridView_recete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recete.Location = new System.Drawing.Point(38, 22);
            this.dataGridView_recete.Name = "dataGridView_recete";
            this.dataGridView_recete.RowHeadersWidth = 51;
            this.dataGridView_recete.RowTemplate.Height = 24;
            this.dataGridView_recete.Size = new System.Drawing.Size(910, 384);
            this.dataGridView_recete.TabIndex = 0;
            // 
            // button_hasta_ad_getir
            // 
            this.button_hasta_ad_getir.Location = new System.Drawing.Point(416, 428);
            this.button_hasta_ad_getir.Name = "button_hasta_ad_getir";
            this.button_hasta_ad_getir.Size = new System.Drawing.Size(75, 32);
            this.button_hasta_ad_getir.TabIndex = 1;
            this.button_hasta_ad_getir.Text = "GETİR";
            this.button_hasta_ad_getir.UseVisualStyleBackColor = true;
            this.button_hasta_ad_getir.Click += new System.EventHandler(this.button_hasta_ad_getir_Click);
            // 
            // label_hasta_adi
            // 
            this.label_hasta_adi.AutoSize = true;
            this.label_hasta_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hasta_adi.Location = new System.Drawing.Point(96, 430);
            this.label_hasta_adi.Name = "label_hasta_adi";
            this.label_hasta_adi.Size = new System.Drawing.Size(113, 25);
            this.label_hasta_adi.TabIndex = 2;
            this.label_hasta_adi.Text = "Hasta ismi: ";
            // 
            // textBox_hasta_adi
            // 
            this.textBox_hasta_adi.Location = new System.Drawing.Point(235, 433);
            this.textBox_hasta_adi.Name = "textBox_hasta_adi";
            this.textBox_hasta_adi.Size = new System.Drawing.Size(136, 22);
            this.textBox_hasta_adi.TabIndex = 3;
            // 
            // receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 490);
            this.Controls.Add(this.textBox_hasta_adi);
            this.Controls.Add(this.label_hasta_adi);
            this.Controls.Add(this.button_hasta_ad_getir);
            this.Controls.Add(this.dataGridView_recete);
            this.Name = "receteler";
            this.Text = "receteler";
            this.Load += new System.EventHandler(this.receteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_recete;
        private System.Windows.Forms.Button button_hasta_ad_getir;
        private System.Windows.Forms.Label label_hasta_adi;
        private System.Windows.Forms.TextBox textBox_hasta_adi;
    }
}