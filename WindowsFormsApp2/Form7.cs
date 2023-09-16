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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void kitapiade_Load(object sender, EventArgs e)
        {
            emanetkitaplistele();
        }
        private void emanetkitaplistele()
        {
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT* FROM EMANETKITAPLAR ", sqlconn);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = komut;
                adapter.Fill(ds, "EMANETKITAPLAR");
                dataGridView1.DataSource = ds.Tables[0];
                komut.ExecuteNonQuery();
                sqlconn.Close();
            }
        }
        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                DataTable tablo = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM EMANETKITAPLAR WHERE OGRENCIADI LIKE '%" + txt_ara.Text.ToString() + "%'", sqlconn);

                dp.Fill(tablo);
                dataGridView1.DataSource = tablo;
                sqlconn.Close();
            }
        }

        private void btn_teslimal_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlconn.Open();

                DateTime teslimTarihi = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["TESLIMTARIH"].Value);
                DateTime iadeTarihi = DateTime.Now;
                int kalanGun = (int)(iadeTarihi - teslimTarihi).TotalDays;

                // DBNull kontrol
                if (dataGridView1.CurrentRow.Cells["KALANGUN"].Value != null && dataGridView1.CurrentRow.Cells["KALANGUN"].Value != DBNull.Value)
                {
                    int eskiKalanGun;
                    if (int.TryParse(dataGridView1.CurrentRow.Cells["KALANGUN"].Value.ToString(), out eskiKalanGun))
                    {
                        kalanGun = Math.Min(kalanGun, eskiKalanGun); // Daha önceki kalan gün sayısını asmamak için min
                    }
                }

                SqlCommand komut = new SqlCommand("UPDATE EMANETKITAPLAR SET KALANGUN = @KALANGUN, IADETARIH = @IADETARIH WHERE KITAPADI = @KITAPADI AND OGRENCIADI = @OGRENCIADI", sqlconn);
                komut.Parameters.AddWithValue("@KITAPADI", dataGridView1.CurrentRow.Cells["KITAPADI"].Value.ToString());
                komut.Parameters.AddWithValue("@OGRENCIADI", dataGridView1.CurrentRow.Cells["OGRENCIADI"].Value.ToString());
                komut.Parameters.AddWithValue("@KALANGUN", kalanGun);
                komut.Parameters.AddWithValue("@IADETARIH", iadeTarihi);
                komut.ExecuteNonQuery();

                sqlconn.Close();
                MessageBox.Show("Kitap teslim alındı.");
                emanetkitaplistele();
            }
        }

    }
}
