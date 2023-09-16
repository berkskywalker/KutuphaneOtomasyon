
namespace WindowsFormsApp2
{
    partial class kitapliste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rafno = new System.Windows.Forms.TextBox();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.Location = new System.Drawing.Point(182, 272);
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(141, 20);
            this.txt_yayinevi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "RAF NUMARASI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "STOK SAYISI";
            // 
            // txt_rafno
            // 
            this.txt_rafno.Location = new System.Drawing.Point(182, 320);
            this.txt_rafno.Name = "txt_rafno";
            this.txt_rafno.Size = new System.Drawing.Size(141, 20);
            this.txt_rafno.TabIndex = 10;
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(182, 141);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(141, 20);
            this.txt_sayfa.TabIndex = 11;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(182, 229);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(141, 20);
            this.txt_stok.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SAYFA SAYISI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "KITAP TURU";
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(182, 98);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(141, 20);
            this.txt_yazar.TabIndex = 13;
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(182, 185);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(141, 20);
            this.txt_tur.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "KITAP YAZARI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "YAYIN EVI :";
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(182, 54);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(141, 20);
            this.txt_kitapadi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "KITAP ADI :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ARA :";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(40, 368);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(283, 29);
            this.btn_guncelle.TabIndex = 18;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(702, 374);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 19;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // kitapliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_yayinevi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_rafno);
            this.Controls.Add(this.txt_sayfa);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kitapadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KITAP LISTESI";
            this.Load += new System.EventHandler(this.kitapliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_yayinevi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rafno;
        private System.Windows.Forms.TextBox txt_sayfa;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
    }
}