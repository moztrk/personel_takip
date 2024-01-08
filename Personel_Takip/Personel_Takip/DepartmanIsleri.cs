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
    public partial class DepartmanIsleri : Form
    {
        public static int yonetimKapasite { get; set; } = 2;
        public static int muhasebeKapasite { get; set; } = 1;
        public static int sekreterKapasite { get; set; } = 2;
        public static int pazarlamaKapasite { get; set; } = 4;
        public static int uretimKapasite { get; set; } = 6;
        public static int lojistikKapasite { get; set; } = 5;


        //+++++++++++++++++++++++++++++++
        

        public DepartmanIsleri()
        {
            InitializeComponent();


        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;

        public static int MevcutPersonelSayisi
        {
            get
            {
                return yonetimKapasite + muhasebeKapasite + sekreterKapasite +
                       pazarlamaKapasite + uretimKapasite + lojistikKapasite;
            }
        }
       
        private void DataGridTablo(string departman,DataGridView dataGridView) // tablolar için
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"SELECT p_ad, p_soyad FROM personel WHERE p_departman = '{departman}'", conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns["p_ad"].HeaderText = "Adı";
            dataGridView.Columns["p_soyad"].HeaderText = "Soyadı";

        }
      

        private void DepartmanIsleri_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            conn.Open();
            DataGridTablo("Yönetim",dataGridViewY);
            DataGridTablo("Muhasebe", dataGridViewM);
            DataGridTablo("Sekreterlik",dataGridViewS);
            DataGridTablo("Pazarlama",dataGridViewP);
            DataGridTablo("Üretim",dataGridViewU);
            DataGridTablo("Lojistik",dataGridViewL);


           
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            Menu f1 = new Menu();
            f1.Show();
            this.Hide();
        }

        private void buttonLabelY_Click(object sender, EventArgs e)
        {
            Yazdirma("Yönetim",labelYmaas);
        }
        public double GiderHesapla()
        {
            double maasGideri = 0;
            double primGideri = 0;
            double genelGider = 0;

            try
            {
                string sorgu = "SELECT p_maas, p_prim FROM personel";
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sorgu, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                maasGideri += Convert.ToDouble(reader["p_maas"]);
                                primGideri += Convert.ToDouble(reader["p_prim"]);
                            }
                        }
                    }
                }

                genelGider = maasGideri + primGideri;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }

            return genelGider;
        }
        private void Yazdirma(string departmanAdi,Label label)
        {
            double toplamMaas = 0;
            double toplamPrim = 0;
            double toplamGider= 0;
            double TumGider= 0;
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                conn.Open();
                string sorgu = $"SELECT p_maas, p_prim FROM personel WHERE p_departman = '{departmanAdi}'";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            toplamMaas += Convert.ToDouble(reader["p_maas"]);
                            toplamPrim += Convert.ToDouble(reader["p_prim"]);

                        }

                    }
                    toplamGider = toplamMaas + toplamPrim;
                    TumGider = GiderHesapla();

                    //departmanın genel gider oranını hesapla
                    double departmanGiderOrani = (toplamGider / TumGider) * 100;
                    label.Text = $"Toplam Maaş: {toplamMaas}\nToplam Prim: {toplamPrim}\nGenel Toplam Maaş Gideri: {toplamMaas + toplamPrim}\nDepartman Gider Oranı: %{departmanGiderOrani:N2}";
                    conn.Close();

                }
               
            }

        }

        private void btnLabelM_Click(object sender, EventArgs e)
        {
            Yazdirma("Muhasebe",lblMmaas);

        }

        private void btnLabelS_Click(object sender, EventArgs e)
        {
            Yazdirma("Sekreterlik",lblSmaas);
        }

        private void btnLabelP_Click(object sender, EventArgs e)
        {
            Yazdirma("Pazarlama", lblPmaas);

        }

        private void btnLabelU_Click(object sender, EventArgs e)
        {
            Yazdirma("Üretim", lblUmaas);
        }

        private void btnLabelL_Click(object sender, EventArgs e)
        {
            Yazdirma("Lojistik",lblLmaas);
        }
    }
    
}
