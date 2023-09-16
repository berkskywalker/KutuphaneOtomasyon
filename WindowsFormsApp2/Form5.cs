using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class kitapliste : Form
    {
        public kitapliste()
        {
            InitializeComponent();
        }
        private void kitapliste_Load(object sender, EventArgs e)
        {
            kitapgetir();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kitapgetir()
        {
            DataSet daset = new DataSet();

            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT* FROM KITAP",sqlconn);
                adtr.Fill(daset, "KITAP");
                dataGridView1.DataSource = daset.Tables["KITAP"];
                sqlconn.Close();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            txt_kitapadi.Text = dataGridView1.CurrentRow.Cells["KITAPADI"].Value.ToString();
            txt_yazar.Text = dataGridView1.CurrentRow.Cells["YAZAR"].Value.ToString();
            txt_sayfa.Text = dataGridView1.CurrentRow.Cells["SAYFA"].Value.ToString();
            txt_tur.Text = dataGridView1.CurrentRow.Cells["TUR"].Value.ToString();
            txt_stok.Text = dataGridView1.CurrentRow.Cells["STOK"].Value.ToString();
            txt_yayinevi.Text = dataGridView1.CurrentRow.Cells["YAYINEVI"].Value.ToString();
            txt_rafno.Text = dataGridView1.CurrentRow.Cells["RAFNO"].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("UPDATE KITAP SET KITAPADI=@KITAPADI, YAZAR=@YAZAR, SAYFA=@SAYFA, TUR=@TUR, STOK=@STOK, YAYINEVI=@YAYINEVI, RAFNO=@RAFNO WHERE KITAPADI=@KITAPADI", sqlconn);
                //kitap adı burada primary key dir kitap adını degistiremezsin. eger kitap adını degistirmeye denersen else bloguna girersin
                
                komut.Parameters.AddWithValue("@KITAPADI", txt_kitapadi.Text);
                komut.Parameters.AddWithValue("@YAZAR", txt_yazar.Text);
                komut.Parameters.AddWithValue("@SAYFA", txt_sayfa.Text);
                komut.Parameters.AddWithValue("@TUR", txt_tur.Text);
                komut.Parameters.AddWithValue("@STOK", txt_stok.Text);
                komut.Parameters.AddWithValue("@YAYINEVI", txt_yayinevi.Text);
                komut.Parameters.AddWithValue("@RAFNO", txt_rafno.Text);
                komut.ExecuteNonQuery();
               
                int rowsAffected = komut.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kitap Güncellendi !");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi sırasında hata oluştu.");
                }

                kitapgetir();
                sqlconn.Close();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();

            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM KITAP WHERE KITAPADI = '" + dataGridView1.CurrentRow.Cells["KITAPADI"].Value.ToString() + "'", sqlconn);
                komut.ExecuteNonQuery();
                sqlconn.Close();
            }
            DataSet ds = new DataSet();

            kitapgetir();
            MessageBox.Show("kayıt silindi");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                DataTable tablo = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM KITAP WHERE KITAPADI LIKE '%" + textBox1.Text.ToString() + "%'", sqlconn);

                dp.Fill(tablo);
                dataGridView1.DataSource = tablo;
                sqlconn.Close();
            }
        }
    }
}
    

