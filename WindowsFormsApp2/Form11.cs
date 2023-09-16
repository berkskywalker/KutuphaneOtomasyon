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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            ogrencilistele();
        }
        private void ogrencilistele()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT *FROM UYE WHERE AD LIKE '"+textBox1.Text+"'", sqlconn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = komut;
                adapter.Fill(ds, "UYE");
                dataGridView1.DataSource = ds.Tables[0];
                komut.ExecuteNonQuery();
                sqlconn.Close();

            }
        }
    }
}
