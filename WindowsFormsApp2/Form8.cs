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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        
        private void emanetkitaplise_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex==0)
            {
                emanetkitaplistele();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlconn.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM EMANETKITAPLAR WHERE TESLIMTARIH IS NOT NULL AND TESLIMTARIH < DATEADD(DAY, -7, GETDATE())", sqlconn);

                    //yukarıdaki sorgu, IADETARIH alanı bos olan veya (SELECT * FROM EMANETKITAPLAR WHERE TESLIMTARIH IS NOT NULL AND TESLIMTARIH < DATEADD(DAY, -7, GETDATE()) kosulunu saglayan kitapları secer. Bu kosul iade tarihi gecmis ve 1 haftayı asan kitapları icerir.

                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = komut;
                    adapter.Fill(ds, "EMANETKITAPLAR");
                    dataGridView1.DataSource = ds.Tables[0];
                    sqlconn.Close();
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlconn.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM EMANETKITAPLAR WHERE TESLIMTARIH IS NOT NULL AND TESLIMTARIH >= DATEADD(DAY, -7, GETDATE())", sqlconn);

                    //bu sorgu da ise suresi gecmeyen yani 7 gun icerisinde iade edilebilir ve edilmis olan kitaplari listeler

                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = komut;
                    adapter.Fill(ds, "EMANETKITAPLAR");
                    dataGridView1.DataSource = ds.Tables[0];
                    sqlconn.Close();
                }
            }
        }
    }
}
