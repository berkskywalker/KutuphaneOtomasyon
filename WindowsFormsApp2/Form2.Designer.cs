
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.btn_uyeekle = new System.Windows.Forms.Button();
            this.txt_kayitsoyad = new System.Windows.Forms.TextBox();
            this.txt_kayitad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_uyeekle
            // 
            this.btn_uyeekle.Location = new System.Drawing.Point(211, 167);
            this.btn_uyeekle.Name = "btn_uyeekle";
            this.btn_uyeekle.Size = new System.Drawing.Size(75, 23);
            this.btn_uyeekle.TabIndex = 9;
            this.btn_uyeekle.Text = "Kayıt Yap";
            this.btn_uyeekle.UseVisualStyleBackColor = true;
            this.btn_uyeekle.Click += new System.EventHandler(this.btn_uyeekle_Click);
            // 
            // txt_kayitsoyad
            // 
            this.txt_kayitsoyad.Location = new System.Drawing.Point(186, 115);
            this.txt_kayitsoyad.Name = "txt_kayitsoyad";
            this.txt_kayitsoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_kayitsoyad.TabIndex = 7;
            this.txt_kayitsoyad.TextChanged += new System.EventHandler(this.txt_kayitsoyad_TextChanged);
            // 
            // txt_kayitad
            // 
            this.txt_kayitad.Location = new System.Drawing.Point(186, 81);
            this.txt_kayitad.Name = "txt_kayitad";
            this.txt_kayitad.Size = new System.Drawing.Size(100, 20);
            this.txt_kayitad.TabIndex = 8;
            this.txt_kayitad.TextChanged += new System.EventHandler(this.txt_kayitad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD :";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AD :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID :";
            // 
            // txt_id
            // 
            this.txt_id.AllowDrop = true;
            this.txt_id.Location = new System.Drawing.Point(186, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 224);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uyeekle);
            this.Controls.Add(this.txt_kayitsoyad);
            this.Controls.Add(this.txt_kayitad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Sayfası ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_uyeekle;
        private System.Windows.Forms.TextBox txt_kayitsoyad;
        private System.Windows.Forms.TextBox txt_kayitad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
    }
}