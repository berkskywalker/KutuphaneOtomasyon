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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
        private void dataGridViewEmanet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            string verilentarih = dataGridViewEmanet.CurrentRow.Cells["VERILENTARIH"].Value.ToString();
            txt_kitapad.Text = dataGridViewEmanet.CurrentRow.Cells["KITAPADI"].Value.ToString();
            txt_kitapyazar.Text = dataGridViewEmanet.CurrentRow.Cells["YAZAR"].Value.ToString();
            txt_kitaptur.Text = dataGridViewEmanet.CurrentRow.Cells["SAYFA"].Value.ToString();
            txt_kitapyayin.Text = dataGridViewEmanet.CurrentRow.Cells["TUR"].Value.ToString();
            txt_kitapyayin.Text = dataGridViewEmanet.CurrentRow.Cells["YAYINEVI"].Value.ToString();
            dateTimePicker1.Text = verilentarih;

        }
        private void sepetlisetle()
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM SEPET", sqlconn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = komut;
                adapter.Fill(ds, "sepet");
                dataGridViewEmanet.DataSource = ds.Tables[0];
            }
        }

        private void BTN_EKLE_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO SEPET(KITAPADI, YAZAR, SAYFA, TUR, YAYINEVI, TESLIMTARIH) VALUES (@KITAPADI, @YAZAR, @SAYFA, @TUR, @YAYINEVI, @TESLIMTARIH)", sqlconn);
                komut.Parameters.AddWithValue("@KITAPADI", txt_kitapad.Text);
                komut.Parameters.AddWithValue("@YAZAR", txt_kitapyazar.Text);
                komut.Parameters.AddWithValue("@SAYFA", txt_sayfa.Text);
                komut.Parameters.AddWithValue("@TUR", txt_kitaptur.Text);
                komut.Parameters.AddWithValue("@YAYINEVI", txt_kitapyayin.Text);
                komut.Parameters.AddWithValue("@TESLIMTARIH", dateTimePicker1.Value);
                komut.ExecuteNonQuery();
                sqlconn.Close();
                sepetlisetle();
                MessageBox.Show("kitap eklendi");
            }
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM UYE WHERE AD LIKE '" + txt_ad.Text + "'", sqlconn);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txt_ad.Text = read["AD"].ToString();
                    txt_soyad.Text = read["SOYAD"].ToString();
                }
                sqlconn.Close();
            }
        }

        private void txt_kitapad_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection())
            {
                sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlconn.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM KITAP WHERE KITAPADI LIKE '" + txt_kitapad.Text + "'", sqlconn);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txt_kitapad.Text = read["KITAPADI"].ToString();
                    txt_kitapyazar.Text = read["YAZAR"].ToString();
                    txt_sayfa.Text = read["SAYFA"].ToString();
                    txt_kitaptur.Text = read["TUR"].ToString();
                    txt_kitapyayin.Text = read["YAYINEVI"].ToString();
                }
                sqlconn.Close();
               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmanet.CurrentRow != null)
            {
                using (SqlConnection sqlconn = new SqlConnection())
                {
                    sqlconn.ConnectionString = @"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    sqlconn.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM SEPET WHERE KITAPADI= '" + dataGridViewEmanet.CurrentRow.Cells["KITAPADI"].Value.ToString() + "' ", sqlconn);
                    komut.ExecuteNonQuery();
                    sqlconn.Close();
                    MessageBox.Show("kitap sepetten silindi");
                    sepetlisetle();
                }
            }
            else
            {
                MessageBox.Show("null deger girildi");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))       
            {
                    sqlconn.Open();
                    for (int i = 0; i < dataGridViewEmanet.Rows.Count - 1; i++)
                    {
                        SqlCommand komut = new SqlCommand("INSERT INTO EMANETKITAPLAR(KITAPADI,YAZAR,SAYFA,TUR,YAYINEVI,TESLIMTARIH,IADETARIH,OGRENCIADI,OGRENCISOYADI) VALUES(@KITAPADI,@YAZAR,@SAYFA,@TUR,@YAYINEVI,@TESLIMTARIH,@IADETARIH,@OGRENCIADI,@OGRENCISOYADI)", sqlconn);

                        komut.Parameters.AddWithValue("@KITAPADI", dataGridViewEmanet.Rows[i].Cells["KITAPADI"].Value.ToString());
                        komut.Parameters.AddWithValue("@YAZAR", dataGridViewEmanet.Rows[i].Cells["YAZAR"].Value.ToString());
                        komut.Parameters.AddWithValue("@SAYFA", dataGridViewEmanet.Rows[i].Cells["SAYFA"].Value.ToString());
                        komut.Parameters.AddWithValue("@TUR", dataGridViewEmanet.Rows[i].Cells["TUR"].Value.ToString());
                        komut.Parameters.AddWithValue("@YAYINEVI", dataGridViewEmanet.Rows[i].Cells["YAYINEVI"].Value.ToString());
                        DateTime teslimTarihi;
                        if (DateTime.TryParse(dataGridViewEmanet.Rows[i].Cells["TESLIMTARIH"].Value.ToString(), out teslimTarihi))
                        {
                            komut.Parameters.AddWithValue("@TESLIMTARIH", teslimTarihi);
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@TESLIMTARIH", DBNull.Value);
                        }

                        DateTime iadeTarihi;
                        if (DateTime.TryParse(dataGridViewEmanet.Rows[i].Cells["IADETARIH"].Value.ToString(), out iadeTarihi))
                        {
                            komut.Parameters.AddWithValue("@IADETARIH", iadeTarihi);
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@IADETARIH", DBNull.Value);
                        }
                        komut.Parameters.AddWithValue("@OGRENCIADI",txt_ad.Text);
                        komut.Parameters.AddWithValue("@OGRENCISOYADI",txt_soyad.Text);
                        komut.ExecuteNonQuery();
                      
                    }
                    sqlconn.Close();
                    sepetlisetle();
                    MessageBox.Show("Kitap teslim edildi.");
                //foreach (Control item in this.Controls)
                //{
                //    if (item is TextBox)
                //    {
                //        item.Text = "";
                //    }
                //}

                using (SqlConnection sqlconn1 = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane_uygulamasi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlconn1.Open();
                    SqlCommand komut1 = new SqlCommand("DELETE FROM SEPET ", sqlconn1);
                    komut1.ExecuteNonQuery();
                    sqlconn.Close();
                    sepetlisetle();
                    //kitapi teslim ettikten sonra kitaplar sepette kalmaya devam ediyordu komut1 de yazdıgım sql sorgusu kitabi teslim ettikten sonra sepetten ilgili kitabi siliyor.
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


