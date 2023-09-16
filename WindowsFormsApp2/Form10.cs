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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    SqlCommand komut = new SqlCommand("UPDATE UYE SET AD = @AD, SOYAD = @SOYAD, NOT1 = @NOT1, NOT2 = @NOT2, ORT = @ORT WHERE ID = @ID", sqlconn);
                    komut.Parameters.AddWithValue("@ID", dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                    komut.Parameters.AddWithValue("@AD", dataGridView1.Rows[i].Cells["AD"].Value.ToString());
                    komut.Parameters.AddWithValue("@SOYAD", dataGridView1.Rows[i].Cells["SOYAD"].Value.ToString());
                    // Notları kontrol et ve uygun bir değer atayarak ortalama değeri hesapla
                    string not1String = txt_not1.Text;
                    string not2String = txt_not2.Text;
                    int not1;
                    int not2;
                    double ortalama;

                    if (int.TryParse(not1String, out not1) && int.TryParse(not2String, out not2))
                    {
                        ortalama = (not1 + not2) / 2;
                    }
                    else
                    {
                        not1 = 0;
                        not2 = 0;
                        ortalama = 0.0;
                    }
    
                    komut.Parameters.AddWithValue("@NOT1", not1);
                    komut.Parameters.AddWithValue("@NOT2", not2);
                    komut.Parameters.AddWithValue("@ORT", ortalama);
                    komut.ExecuteNonQuery();
                }
                ogr();
                sqlconn.Close();
                MessageBox.Show("kayıt guncellendi");

            }
        }




        private void Form10_Load(object sender, EventArgs e)
        {
            ogr();

        }

        private void ogr()
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT *FROM UYE", sqlconn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = komut;
                adapter.Fill(ds, "UYE");
                dataGridView1.DataSource = ds.Tables[0];
                komut.ExecuteNonQuery();
                sqlconn.Close();
            }
        }
        private void txt_ogrenciid_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM UYE WHERE ID LIKE '" + txt_ogrenciid.Text + "'", sqlconn);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txt_ad.Text = read["AD"].ToString();
                    txt_soyad.Text = read["SOYAD"].ToString();
                    txt_not1.Text = read["NOT1"].ToString();
                    txt_not2.Text = read["NOT2"].ToString();
                    txt_ort.Text = read["ORT"].ToString();
                }
                sqlconn.Close();
            }
        }
        
    }
}
