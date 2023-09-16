
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.dataGridViewOgrenci = new System.Windows.Forms.DataGridView();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgrenci
            // 
            this.dataGridViewOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenci.Location = new System.Drawing.Point(228, 59);
            this.dataGridViewOgrenci.Name = "dataGridViewOgrenci";
            this.dataGridViewOgrenci.Size = new System.Drawing.Size(318, 166);
            this.dataGridViewOgrenci.TabIndex = 0;
            this.dataGridViewOgrenci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgrenci_CellDoubleClick);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(100, 147);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 11;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(100, 113);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 12;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "AD :";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(12, 231);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(209, 29);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(437, 23);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(109, 20);
            this.txt_ara.TabIndex = 17;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(368, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "ARA :";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(448, 231);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(98, 29);
            this.btn_sil.TabIndex = 19;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(100, 76);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 281);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOgrenci);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOgrenci;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
    }
}