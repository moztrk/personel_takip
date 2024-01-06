using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Personel_Takip
{
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;


        private void button1_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

       
        void Listele() // bu fonksyon hem buttonda hemde load kısmında kullanılması için
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
        private void button2_Click(object sender, EventArgs e)
        {
          Listele();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Listele();
            // tablo başlıklarının ismini çevirme
            dataGridView1.Columns["p_no"].HeaderText = "Personel Numarası";
            dataGridView1.Columns["p_ad"].HeaderText = "Adı";
            dataGridView1.Columns["p_soyad"].HeaderText = "Soyadı";
            dataGridView1.Columns["p_maas"].HeaderText = "Maaş";
            dataGridView1.Columns["p_isegiris"].HeaderText = "İşe Giriş Tarihi";
            dataGridView1.Columns["p_kimlik"].HeaderText = "TC Kimlik Numarası";
            dataGridView1.Columns["p_zamtarihi"].HeaderText = "Son Zam Tarihi";
            dataGridView1.Columns["p_prim"].HeaderText = "Güncel Prim";
            dataGridView1.Columns["p_primyenilemetarihi"].HeaderText = "Prim Güncellme Tarihi";
            dataGridView1.Columns["p_kalanizinhakkı"].HeaderText = "Kalan Yıllık İzin Hakkı";
            dataGridView1.Columns["p_departman"].HeaderText = "Departman";
        }

       
    }
}
