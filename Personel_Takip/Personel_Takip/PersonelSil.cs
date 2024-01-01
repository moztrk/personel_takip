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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personel_Takip
{
    public partial class PersonelSil : Form
    {
        private const int MaxPersonelSayisi = 20; // Max personel için

        private int kalanEklemeHakki;
        public PersonelSil()
        {
            InitializeComponent();
            kalanEklemeHakki = MaxPersonelSayisi - MevcutPersonelSayisi();
            UpdateProgressBar();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void PersonelSil_Load(object sender, EventArgs e)
        {
            Listele();
           
            dataGridView1.Columns["p_no"].HeaderText = "Personel Numarası";
            dataGridView1.Columns["p_ad"].HeaderText = "Adı";
            dataGridView1.Columns["p_soyad"].HeaderText = "Soyadı";
            dataGridView1.Columns["p_maas"].HeaderText = "Maaş";
            dataGridView1.Columns["p_isegiris"].HeaderText = "İşe Giriş Tarihi";
            dataGridView1.Columns["p_kimlik"].HeaderText = "TC Kimlik Numarası";
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
        private void UpdateProgressBar()
        {
            // ProgressBar
            int dolulukOrani = (MaxPersonelSayisi - kalanEklemeHakki) * 100 / MaxPersonelSayisi;
            progressBarSilme.Value = dolulukOrani;
            labelDoluluk.Text = $"Doluluk Oranı: {dolulukOrani}%"; // labela oran yazdırma

        }
        private int MevcutPersonelSayisi() //doluluk oranı progress için
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GirisEkranı.accdb");
            cmd = new OleDbCommand("SELECT COUNT(*) FROM personel", conn);

            conn.Open();
            int personelSayisi = (int)cmd.ExecuteScalar();
            conn.Close();

            return personelSayisi;
        }

        private void sBtnAnamenü_Click(object sender, EventArgs e)
        {
            Menu f1 = new Menu();
            f1.Show();
            this.Hide();
        }

        private void sButonsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili personeli silmek istiyor musunuz?", "Personel Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Seçili satırın personel numarasını al
                        int personelNo = (int)dataGridView1.SelectedRows[0].Cells["p_no"].Value;

                        // Silme işlemi 
                        string query = "DELETE FROM personel WHERE p_no = @personelNo";

                        
                        using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GirisEkranı.accdb"))
                        using (OleDbCommand cmd = new OleDbCommand(query, connection))
                        {
                            connection.Open();
                            cmd.Parameters.AddWithValue("@personelNo", personelNo);
                            cmd.ExecuteNonQuery();
                        }

                    
                        Listele();
                        UpdateProgressBar();//barı yenileme


                        MessageBox.Show("Personel başarıyla silindi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void sbuttonlistele_Click(object sender, EventArgs e)
        {
            Listele();
            UpdateProgressBar();
        }
    }
}
