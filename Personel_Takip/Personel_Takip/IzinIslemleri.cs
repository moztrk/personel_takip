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

namespace Personel_Takip
{
    public partial class IzinIslemleri : Form
    {
        public IzinIslemleri()
        {
            InitializeComponent();
        }
        private void ComboboxDoldur()
        {


            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        string query = "SELECT p_ad, p_soyad FROM personel";

                        using (OleDbCommand command = new OleDbCommand(query, conn))// using de nesne kullanımı bittiğinde kaynakları dispose eder 
                        {// yani using burada kaynakları serbest bıraktı parantez bitince conn close a gerek kalmadı
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string ad = reader["p_ad"].ToString();
                                    string soyad = reader["p_soyad"].ToString();
                                    comboBoxIzin.Items.Add($"{ad} {soyad}");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message);
                    }
                }
            }
        }
        private void buttonIzın_Click(object sender, EventArgs e)
        {
            if (comboBoxIzin.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir personel seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedPerson = comboBoxIzin.SelectedItem.ToString();
            string[] parts = selectedPerson.Split(' ');
            string ad = parts[0];
            string soyad = parts[1];
            int izinKullanilan = Convert.ToInt32(numericUpDownIzin.Value);

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                conn.Open(); 

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;

                    try
                    {
                        string queryGetIzin = "SELECT p_kalanizinhakki FROM personel WHERE p_ad = @Ad AND p_soyad = @Soyad";
                        cmd.CommandText = queryGetIzin;
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        int kalanIzin = Convert.ToInt32(cmd.ExecuteScalar());

                        //izin miktarı kontrolü
                        if (izinKullanilan > kalanIzin)
                        {
                            MessageBox.Show($"{ad} {soyad} adlı personelin izin hakkı yetersiz. İzin verilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //izin hakkını güncelle
                        string queryUpdateIzin = "UPDATE personel SET p_kalanizinhakki = @KalanIzin WHERE p_ad = @Ad AND p_soyad = @Soyad";
                        cmd.CommandText = queryUpdateIzin;
                        cmd.Parameters.Clear(); // parametreleri temizle
                        cmd.Parameters.AddWithValue("@KalanIzin", kalanIzin - izinKullanilan);
                        cmd.Parameters.AddWithValue("@Ad", ad); 
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{ad} {soyad} adlı personelin izin hakkı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"{ad} {soyad} adlı personelin izin hakkı güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void IzinIslemleri_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            Menu f1 = new Menu();
            f1.Show();
            this.Hide();
        }
    }
}
