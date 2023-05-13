namespace hastane_otomasyon
{
    partial class Hasta_Sil
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.dataGridView_hastalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(7, 21);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(64, 45);
            this.button_geri.TabIndex = 59;
            this.button_geri.Text = "geri";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(338, 370);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(125, 22);
            this.textBox_id.TabIndex = 58;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(246, 370);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(63, 16);
            this.label_id.TabIndex = 57;
            this.label_id.Text = "Hasta id: ";
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(500, 362);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(112, 34);
            this.button_sil.TabIndex = 56;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // dataGridView_hastalar
            // 
            this.dataGridView_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hastalar.Location = new System.Drawing.Point(77, 21);
            this.dataGridView_hastalar.Name = "dataGridView_hastalar";
            this.dataGridView_hastalar.RowHeadersWidth = 51;
            this.dataGridView_hastalar.RowTemplate.Height = 24;
            this.dataGridView_hastalar.Size = new System.Drawing.Size(800, 309);
            this.dataGridView_hastalar.TabIndex = 55;
            // 
            // Hasta_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 439);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.dataGridView_hastalar);
            this.Name = "Hasta_Sil";
            this.Text = "Hasta_Sil";
            this.Load += new System.EventHandler(this.Hasta_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.DataGridView dataGridView_hastalar;
    }
}