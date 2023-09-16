namespace WindowsFormsApp2
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_kitapyayin = new System.Windows.Forms.TextBox();
            this.txt_kitaptur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kitapyazar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitapad = new System.Windows.Forms.TextBox();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_EKLE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(94, 61);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYAD :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(94, 23);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_kitapyayin);
            this.groupBox2.Controls.Add(this.txt_kitaptur);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_kitapyazar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_sayfa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_kitapad);
            this.groupBox2.Location = new System.Drawing.Point(24, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txt_kitapyayin
            // 
            this.txt_kitapyayin.Location = new System.Drawing.Point(106, 188);
            this.txt_kitapyayin.Name = "txt_kitapyayin";
            this.txt_kitapyayin.Size = new System.Drawing.Size(106, 20);
            this.txt_kitapyayin.TabIndex = 8;
            // 
            // txt_kitaptur
            // 
            this.txt_kitaptur.Location = new System.Drawing.Point(106, 149);
            this.txt_kitaptur.Name = "txt_kitaptur";
            this.txt_kitaptur.Size = new System.Drawing.Size(106, 20);
            this.txt_kitaptur.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "TESLİM TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "SAYFA ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "YAYIN EVI";
            // 
            // txt_kitapyazar
            // 
            this.txt_kitapyazar.Location = new System.Drawing.Point(106, 72);
            this.txt_kitapyazar.Name = "txt_kitapyazar";
            this.txt_kitapyazar.Size = new System.Drawing.Size(106, 20);
            this.txt_kitapyazar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "KITAP ADI :";
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(106, 111);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(106, 20);
            this.txt_sayfa.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "YAZAR";
            // 
            // txt_kitapad
            // 
            this.txt_kitapad.Location = new System.Drawing.Point(106, 34);
            this.txt_kitapad.Name = "txt_kitapad";
            this.txt_kitapad.Size = new System.Drawing.Size(106, 20);
            this.txt_kitapad.TabIndex = 13;
            this.txt_kitapad.TextChanged += new System.EventHandler(this.txt_kitapad_TextChanged);
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(278, 46);
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.Size = new System.Drawing.Size(527, 457);
            this.dataGridViewEmanet.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(829, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "TESLİM ET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_EKLE
            // 
            this.BTN_EKLE.Location = new System.Drawing.Point(24, 509);
            this.BTN_EKLE.Name = "BTN_EKLE";
            this.BTN_EKLE.Size = new System.Drawing.Size(223, 28);
            this.BTN_EKLE.TabIndex = 5;
            this.BTN_EKLE.Text = "EKLE ";
            this.BTN_EKLE.UseVisualStyleBackColor = true;
            this.BTN_EKLE.Click += new System.EventHandler(this.BTN_EKLE_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 551);
            this.Controls.Add(this.BTN_EKLE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEmanet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form6";
            this.Text = "Emanet Kitap Verme Sayfası";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.TextBox txt_kitapyayin;
        private System.Windows.Forms.TextBox txt_kitaptur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_kitapyazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kitapad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_EKLE;
        private System.Windows.Forms.Label label8;
    }
}