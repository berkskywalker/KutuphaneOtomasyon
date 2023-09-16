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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            derslistele();
        }
        private void derslistele()
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT *FROM DERS", sqlconn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = komut;
                adapter.Fill(ds, "DERS");
                dataGridView1.DataSource = ds.Tables[0];
                komut.ExecuteNonQuery();
                sqlconn.Close();

            }
        }
        private void textBox1_id_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM UYE WHERE ID LIKE '" + textBox1_id.Text + "'", sqlconn);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txt_ogrenciadi.Text = read["AD"].ToString();
                    txt_ogrencisoyadi.Text = read["SOYAD"].ToString();
                }
                sqlconn.Close();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1_id.Text);

            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                string ogrenciBilgisiSorgusu = "SELECT ad, soyad FROM UYE WHERE ID = @ID";
                SqlCommand ogrenciBilgisiKomutu = new SqlCommand(ogrenciBilgisiSorgusu, sqlconn);
                ogrenciBilgisiKomutu.Parameters.AddWithValue("@ID", ID);  
                SqlDataReader ogrenciBilgisiOkuyucu = ogrenciBilgisiKomutu.ExecuteReader();
                string ogrenciAdi = "";
                string ogrenciSoyadi = "";
                if (ogrenciBilgisiOkuyucu.Read())
                {
                    ogrenciAdi = ogrenciBilgisiOkuyucu.GetString(0); // ad sütununun indeksi
                    ogrenciSoyadi = ogrenciBilgisiOkuyucu.GetString(1); // soyad sütununun indeksi
                }
                ogrenciBilgisiOkuyucu.Close();
                SqlCommand komut = new SqlCommand("INSERT INTO DERS(DERSADI, OGRENCIADI, OGRENCISOYADI) VALUES (@DERSADI, @OGRENCIADI, @OGRENCISOYADI)", sqlconn);
                komut.Parameters.AddWithValue("@DERSADI", txt_ders.Text);
                komut.Parameters.AddWithValue("@OGRENCIADI", ogrenciAdi);
                komut.Parameters.AddWithValue("@OGRENCISOYADI", ogrenciSoyadi);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi");
                derslistele();
                sqlconn.Close();
            }
        }
    }
}
