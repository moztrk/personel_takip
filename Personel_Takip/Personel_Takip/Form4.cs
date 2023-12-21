using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Personel_Takip
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        void Listele()// listelemek için
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter(selectCommandText: "SELECT * FROM personel ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string tc = txtTc.Text;
                string maas = txtMaas.Text;
                DateTime now = DateTime.Now;
                string formattedDate = now.ToString("dd/MM/yyyy");
                string girisTarihi = formattedDate;//tarihi güncel tarih olarak eklemesi için

                if (ad == "" || soyad == "" || tc == "" || maas == "")
                {
                    MessageBox.Show("Lütfen tüm bilgileri girin.");

                }
                else
                {


                    conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
                    cmd = new OleDbCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    string query = "INSERT INTO personel (p_ad, p_soyad, p_maas, p_isegiris, p_kimlik) " +
                            "VALUES (@ad, @soyad, @maas, @girisTarihi, @tc)";
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@maas", maas);
                    cmd.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla eklendi.");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Listele();
        }

    }

    }

