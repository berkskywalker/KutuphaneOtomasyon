
namespace WindowsFormsApp2
{
    partial class kitapekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.txt_rafno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KITAP ADI :";
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(178, 30);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(141, 20);
            this.txt_kitapadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KITAP YAZARI :";
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(178, 74);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(141, 20);
            this.txt_yazar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SAYFA SAYISI";
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(178, 117);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(141, 20);
            this.txt_sayfa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "YAYIN EVI :";
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(178, 161);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(141, 20);
            this.txt_tur.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "KITAP TURU";
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(178, 205);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(141, 20);
            this.txt_stok.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "STOK SAYISI";
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.Location = new System.Drawing.Point(178, 248);
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(141, 20);
            this.txt_yayinevi.TabIndex = 1;
            // 
            // txt_rafno
            // 
            this.txt_rafno.Location = new System.Drawing.Point(178, 296);
            this.txt_rafno.Name = "txt_rafno";
            this.txt_rafno.Size = new System.Drawing.Size(141, 20);
            this.txt_rafno.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "RAF NUMARASI :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(36, 354);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(283, 32);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // kitapekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 407);
            this.Controls.Add(this.btn_ekle);
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
            this.Name = "kitapekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_yayinevi;
        private System.Windows.Forms.TextBox txt_rafno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ekle;
    }
}