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
    public partial class Dogrulama : Form
    {
        public Dogrulama()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void Dogrulama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string tc= tkimlik.Text;
            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM login where k_kimlik = '" + tkimlik.Text +"'";
            reader = cmd.ExecuteReader();
            if (reader.Read() )
            {
                string sifre = reader["k_sifre"].ToString();
                MessageBox.Show("Şifreniz: " + sifre);

            }
            else
            {
                MessageBox.Show("Lütfen geçerli TC Kimlik Numarası giriniz!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisEkrani form1 = new GirisEkrani();
            form1.Show();
            this.Hide();
        }
        private void Dogrulama_Resize(object sender, EventArgs e)
        {
            tcButton.Width = this.Width / 10;  // Form genişliğinin 10'da biri kadar
            tcButton.Height = this.Height / 20;  // Form yüksekliğinin 20'de biri kadar
        }

    }
    }

