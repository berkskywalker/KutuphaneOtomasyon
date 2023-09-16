
namespace WindowsFormsApp2
{
    partial class Form9
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
            this.txt_ogrenciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogrencisoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ders = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci Adı ";
            // 
            // txt_ogrenciadi
            // 
            this.txt_ogrenciadi.Location = new System.Drawing.Point(137, 54);
            this.txt_ogrenciadi.Name = "txt_ogrenciadi";
            this.txt_ogrenciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrenciadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ogrenci Soyadı";
            // 
            // txt_ogrencisoyadi
            // 
            this.txt_ogrencisoyadi.Location = new System.Drawing.Point(137, 94);
            this.txt_ogrencisoyadi.Name = "txt_ogrencisoyadi";
            this.txt_ogrencisoyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrencisoyadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ders Adı";
            // 
            // txt_ders
            // 
            this.txt_ders.Location = new System.Drawing.Point(137, 139);
            this.txt_ders.Name = "txt_ders";
            this.txt_ders.Size = new System.Drawing.Size(100, 20);
            this.txt_ders.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(36, 189);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(201, 36);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "DERS EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 178);
            this.dataGridView1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ogrenci ID";
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(137, 17);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(100, 20);
            this.textBox1_id.TabIndex = 4;
            this.textBox1_id.TextChanged += new System.EventHandler(this.textBox1_id_TextChanged);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 256);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_ders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ogrencisoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ogrenciadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci Dersleri";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogrenciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogrencisoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ders;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_id;
    }
}