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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void txt_kayitad_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ogrencigetir();
        }
        private void ogrencigetir()
        {
            DataSet daset = new DataSet();
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM UYE ",sqlconn);
                adtr.Fill(daset, "KITAP");
                dataGridViewOgrenci.DataSource = daset.Tables["KITAP"];
                sqlconn.Close();
            }
        }
        private void dataGridViewOgrenci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridViewOgrenci.CurrentRow.Cells["ID"].Value.ToString();
            txt_ad.Text = dataGridViewOgrenci.CurrentRow.Cells["AD"].Value.ToString();
            txt_soyad.Text = dataGridViewOgrenci.CurrentRow.Cells["SOYAD"].Value.ToString();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("UPDATE OGRENCI SET ADI=@ADI, YAZAR=@YAZAR, SOYADI=@SOYADI, TUR=@TUR, STOK=@STOK, YAYINEVI=@YAYINEVI, RAFNO=@RAFNO WHERE KITAPADI=@KITAPADI", sqlconn);
                //Ogrenci ID adı burada primary key dir kitap adını degistiremezsin. eger kitap adını degistirmeye denersen else bloguna girersin

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

                ogrencigetir();
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
                SqlCommand komut = new SqlCommand("DELETE FROM UYE WHERE ID = '" + dataGridViewOgrenci.CurrentRow.Cells["ID"].Value.ToString() + "'", sqlconn);
                komut.ExecuteNonQuery();
                sqlconn.Close();
            }
            DataSet ds = new DataSet();

            ogrencigetir();
            MessageBox.Show("kayıt silindi");
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                DataTable tablo = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM UYE WHERE ID LIKE '%" + txt_ara.Text.ToString() + "%'", sqlconn);

                dp.Fill(tablo);
                dataGridViewOgrenci.DataSource = tablo;
                sqlconn.Close();
            }
        }
    }
}
