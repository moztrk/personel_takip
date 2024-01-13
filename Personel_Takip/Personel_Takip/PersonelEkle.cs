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
    public partial class PersonelEkle : Form
    {
        public int MaxPersonelSayisi = Kapasite.Mevcut();


        private int kalanEklemeHakki;

        public PersonelEkle()
        {
            InitializeComponent();
            kalanEklemeHakki = MaxPersonelSayisi-MevcutPersonelSayisi();
            UpdateProgressBar();


        }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;

        private void Form4_Load(object sender, EventArgs e)
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
            dataGridView1.Columns["p_kalanizinhakki"].HeaderText = "Kalan Yıllık İzin Hakkı";
            dataGridView1.Columns["p_departman"].HeaderText = "Departman";



            comboBoxDepartman.Items.Add("Yonetim");
            comboBoxDepartman.Items.Add("Muhasebe"); 
            comboBoxDepartman.Items.Add("Sekreterlik");
            comboBoxDepartman.Items.Add("Pazarlama");
            comboBoxDepartman.Items.Add("Üretim");
            comboBoxDepartman.Items.Add("Lojistik");
        }

        void Listele()
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

        private int MevcutPersonelSayisi()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GirisEkranı.accdb");
            cmd = new OleDbCommand("SELECT COUNT(*) FROM personel", conn);// toplam personel sayısı

            conn.Open();
            int personelSayisi = (int)cmd.ExecuteScalar();//inte çevirme ve scalar count sorgusu tek değer döndürdüğü için
            conn.Close();

            return personelSayisi;
        }

       
        private void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtTc.Text = string.Empty;
            txtMaas.Text = string.Empty;
            textBoxP.Text = string.Empty;
        }

        private void buttonDonMenu_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Listele();
            UpdateProgressBar();
        }
        private void UpdateProgressBar()
        {
            // ProgressBar
            int dolulukOrani = (MaxPersonelSayisi - kalanEklemeHakki) * 100 / MaxPersonelSayisi;
            ekleProgressBar.Value = dolulukOrani;
            labelDolulukOrani.Text = $"Doluluk Oranı: {dolulukOrani}%"; // labela oran yazdırma

        }



        // buralar texboxtların veri türü
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { 
            e.Handled = true;
            
            }
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled |= true;
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled |= true;
            }
        }

        private void txtTc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) // del tuşuna basınca komple silmesi için
            {
                txtTc.Text = string.Empty;
            }
        }

        private void txtMaas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                txtMaas.Text = string.Empty;
            }
        }

        private void textBoxP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                textBoxP.Text = string.Empty;
            }
        }

        private void textBoxP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void buttonEkle_Click_1(object sender, EventArgs e)
        {
            try
            {

                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string tc = txtTc.Text;
                string maas = txtMaas.Text;
                string departman = comboBoxDepartman.SelectedItem?.ToString();
                string prim = textBoxP.Text;
                int izin = 30;

                DateTime now = DateTime.Now;// eklenecek olan personelin işe başladığı gün
                string formattedDate = now.ToString("dd/MM/yyyy");
                string girisTarihi = formattedDate;

                int mevcutPersonelSayisi = MevcutPersonelSayisi();

                if (mevcutPersonelSayisi >= MaxPersonelSayisi)
                {
                    MessageBox.Show("Personel eklenemez, maksimum personel sayısına ulaşıldı.");
                    return;
                }

                if (ad == "" || soyad == "" || tc == "" || maas == "" || prim == "" || departman == null)
                {
                    MessageBox.Show("Lütfen tüm bilgileri girin ve bir departman seçin.");
                }
                else
                {
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=GirisEkranı.accdb");
                    cmd = new OleDbCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    string query = "INSERT INTO personel (p_ad, p_soyad, p_maas, p_isegiris, p_kimlik, p_departman,p_prim,p_kalanizinhakki) " +
                                      "VALUES (@ad, @soyad, @maas, @girisTarihi, @tc, @departman,@prim,@izin)";

                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@maas", maas);
                    cmd.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@departman", departman);
                    cmd.Parameters.AddWithValue("@prim", prim);
                    cmd.Parameters.AddWithValue("@izin", izin);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();



                    kalanEklemeHakki = MaxPersonelSayisi - mevcutPersonelSayisi;
                    UpdateProgressBar();
                    MessageBox.Show($"Personel başarıyla eklendi. Kalan personel ekleme hakkınız: {--kalanEklemeHakki}");
                    Listele();
                    Temizle();


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
    }
}
