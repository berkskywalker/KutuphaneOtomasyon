using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconn = new SqlConnection("Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_uyeekle_Click(object sender, EventArgs e)
        {
            Form2 uyeform = new Form2();

            uyeform.Show();

        }

        private void btn_uyelistele_Click(object sender, EventArgs e)
        {
            Form3 uyeliste = new Form3();

            uyeliste.Show();
        }
      

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            kitapekle ktp = new kitapekle();
            ktp.Show();
        }

        private void btn_kitaplistele_Click(object sender, EventArgs e)
        {
            kitapliste ktp = new kitapliste();
            ktp.Show();
        }

        private void btn_kitapver_Click(object sender, EventArgs e)
        {
            Form6 form= new Form6();
            form.Show();
        }

        private void btn_emanetkitapliste_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();

        }

        private void btn_kitapal_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }
    }
}
