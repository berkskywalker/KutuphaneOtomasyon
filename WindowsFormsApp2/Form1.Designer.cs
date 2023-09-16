
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_emanetkitapliste = new System.Windows.Forms.Button();
            this.btn_kitapal = new System.Windows.Forms.Button();
            this.btn_kitapver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kitaplistele = new System.Windows.Forms.Button();
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_uyelistele = new System.Windows.Forms.Button();
            this.btn_uyeekle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_emanetkitapliste);
            this.groupBox2.Controls.Add(this.btn_kitapal);
            this.groupBox2.Controls.Add(this.btn_kitapver);
            this.groupBox2.Location = new System.Drawing.Point(43, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emanet Kitap İşlemleri";
            // 
            // btn_emanetkitapliste
            // 
            this.btn_emanetkitapliste.Location = new System.Drawing.Point(31, 115);
            this.btn_emanetkitapliste.Name = "btn_emanetkitapliste";
            this.btn_emanetkitapliste.Size = new System.Drawing.Size(206, 23);
            this.btn_emanetkitapliste.TabIndex = 0;
            this.btn_emanetkitapliste.Text = "Emanet Kitaplar Listesi";
            this.btn_emanetkitapliste.UseVisualStyleBackColor = true;
            this.btn_emanetkitapliste.Click += new System.EventHandler(this.btn_emanetkitapliste_Click);
            // 
            // btn_kitapal
            // 
            this.btn_kitapal.Location = new System.Drawing.Point(31, 75);
            this.btn_kitapal.Name = "btn_kitapal";
            this.btn_kitapal.Size = new System.Drawing.Size(206, 23);
            this.btn_kitapal.TabIndex = 0;
            this.btn_kitapal.Text = "Emanet Kitap Al";
            this.btn_kitapal.UseVisualStyleBackColor = true;
            this.btn_kitapal.Click += new System.EventHandler(this.btn_kitapal_Click);
            // 
            // btn_kitapver
            // 
            this.btn_kitapver.Location = new System.Drawing.Point(31, 35);
            this.btn_kitapver.Name = "btn_kitapver";
            this.btn_kitapver.Size = new System.Drawing.Size(206, 23);
            this.btn_kitapver.TabIndex = 0;
            this.btn_kitapver.Text = "Emanet Kitap Ver";
            this.btn_kitapver.UseVisualStyleBackColor = true;
            this.btn_kitapver.Click += new System.EventHandler(this.btn_kitapver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kitaplistele);
            this.groupBox3.Controls.Add(this.btn_kitapekle);
            this.groupBox3.Location = new System.Drawing.Point(479, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İşlemleri";
            // 
            // btn_kitaplistele
            // 
            this.btn_kitaplistele.Location = new System.Drawing.Point(34, 85);
            this.btn_kitaplistele.Name = "btn_kitaplistele";
            this.btn_kitaplistele.Size = new System.Drawing.Size(206, 23);
            this.btn_kitaplistele.TabIndex = 0;
            this.btn_kitaplistele.Text = "Kitap Listesi";
            this.btn_kitaplistele.UseVisualStyleBackColor = true;
            this.btn_kitaplistele.Click += new System.EventHandler(this.btn_kitaplistele_Click);
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Location = new System.Drawing.Point(34, 36);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(206, 23);
            this.btn_kitapekle.TabIndex = 0;
            this.btn_kitapekle.Text = "Yeni Kitap Ekle";
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_kitapekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_uyelistele);
            this.groupBox1.Controls.Add(this.btn_uyeekle);
            this.groupBox1.Location = new System.Drawing.Point(43, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btn_uyelistele
            // 
            this.btn_uyelistele.Location = new System.Drawing.Point(31, 85);
            this.btn_uyelistele.Name = "btn_uyelistele";
            this.btn_uyelistele.Size = new System.Drawing.Size(206, 23);
            this.btn_uyelistele.TabIndex = 0;
            this.btn_uyelistele.Text = "Üye Listesi";
            this.btn_uyelistele.UseVisualStyleBackColor = true;
            this.btn_uyelistele.Click += new System.EventHandler(this.btn_uyelistele_Click);
            // 
            // btn_uyeekle
            // 
            this.btn_uyeekle.Location = new System.Drawing.Point(31, 36);
            this.btn_uyeekle.Name = "btn_uyeekle";
            this.btn_uyeekle.Size = new System.Drawing.Size(206, 23);
            this.btn_uyeekle.TabIndex = 0;
            this.btn_uyeekle.Text = "Yeni Üye Ekleme";
            this.btn_uyeekle.UseVisualStyleBackColor = true;
            this.btn_uyeekle.Click += new System.EventHandler(this.btn_uyeekle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(479, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 161);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci İşlemleri";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Öğrenci Listesi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Öğrencilerin Aldıgı Dersler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrencilerin Notları";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KutuphaneHomePage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_emanetkitapliste;
        private System.Windows.Forms.Button btn_kitapal;
        private System.Windows.Forms.Button btn_kitapver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_kitaplistele;
        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_uyelistele;
        private System.Windows.Forms.Button btn_uyeekle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

