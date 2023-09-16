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

    public partial class Form2 : Form
    {

        public SqlConnection sqlconn = new SqlConnection();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_uyeekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO UYE(ID, AD, SOYAD) VALUES (@ID, @AD, @SOYAD)", sqlconn);
                komut.Parameters.AddWithValue("@ID", txt_id.Text);
                komut.Parameters.AddWithValue("@AD", txt_kayitad.Text);
                komut.Parameters.AddWithValue("@SOYAD", txt_kayitsoyad.Text);
                komut.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Üye Eklendi !");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txt_kayitad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kayitsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}

