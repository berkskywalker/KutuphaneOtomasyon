using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
           
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO KITAP(KITAPADI, YAZAR, SAYFA, TUR, STOK, YAYINEVI, RAFNO) VALUES (@KITAPADI, @YAZAR, @SAYFA, @TUR, @STOK, @YAYINEVI, @RAFNO)", sqlconn);
              
                komut.Parameters.AddWithValue("@KITAPADI", txt_kitapadi.Text);
                komut.Parameters.AddWithValue("@YAZAR", txt_yazar.Text);
                komut.Parameters.AddWithValue("@SAYFA", txt_sayfa.Text);
                komut.Parameters.AddWithValue("@TUR", txt_tur.Text);
                komut.Parameters.AddWithValue("@STOK", txt_stok.Text);
                komut.Parameters.AddWithValue("@YAYINEVI", txt_yayinevi.Text);
                komut.Parameters.AddWithValue("@RAFNO", txt_rafno.Text);

                komut.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Kitap Eklendi !");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = ""; 
                    }
                }
            }
        }

        

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
