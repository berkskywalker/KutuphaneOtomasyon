
namespace WindowsFormsApp2
{
    partial class Form7
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
            this.btn_teslimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_teslimal
            // 
            this.btn_teslimal.Location = new System.Drawing.Point(725, 493);
            this.btn_teslimal.Name = "btn_teslimal";
            this.btn_teslimal.Size = new System.Drawing.Size(75, 38);
            this.btn_teslimal.TabIndex = 1;
            this.btn_teslimal.Text = "Teslim Al";
            this.btn_teslimal.UseVisualStyleBackColor = true;
            this.btn_teslimal.Click += new System.EventHandler(this.btn_teslimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARA ";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(700, 19);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_ara.TabIndex = 3;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_teslimal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İade Sayfası";
            this.Load += new System.EventHandler(this.kitapiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_teslimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ara;
    }
}