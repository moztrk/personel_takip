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
    public partial class MaasIsleri : Form
    {


        public MaasIsleri()
        {
            InitializeComponent();

            panelYuzde.Visible = false;// panellerin radiobutona basıldığında açılması için ilk başta false
            panelNormal.Visible = false;
            ComboBoxYuzdeDoldur();
            ComboBoxNormalDoldur();
        }


        private void MaasIsleri_Load(object sender, EventArgs e)
        {

        }

     


       
        private void ComboBoxYuzdeDoldur() //yuzdeli zamın comboxu
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

                        using (OleDbCommand command = new OleDbCommand(query, conn))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string ad = reader["p_ad"].ToString();
                                    string soyad = reader["p_soyad"].ToString();
                                    comboBoxYuzde.Items.Add($"{ad} {soyad}"); //adsoyadı tam isim olarak ekleme
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
        private void ComboBoxNormalDoldur()
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
                                    comboBoxNormal.Items.Add($"{ad} {soyad}");
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

        private void radioButtonYuzde_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYuzde.Checked)
            {
                panelYuzde.Visible = true;
                panelNormal.Visible = false;

                // diğer paneli gizle
                if (panelNormal.Visible)
                {
                    panelNormal.Visible = false;
                }
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNormal.Checked)
            {
                panelYuzde.Visible = false;
                panelNormal.Visible = true;

                // aDiğer paneli gizle
                if (panelYuzde.Visible)
                {
                    panelYuzde.Visible = false;
                }
            }
        }

        private void btnMaasGuncelleYuzde_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxYuzde.SelectedIndex != -1) // mantık comboda birşey seçili değilse index -1  yani false oluyor ama seçildiğinde true

                {
                    if (int.TryParse(txtYuzdeMaas.Text, out int yuzde)) // ****** burada önemli işlem 
                    {
                        // burada textboxtan alınan değer tryparse yapılıyor eğer çevrilirse true döndürüyor çevrilmesse else gidiyor 
                        string secilenPersonel = comboBoxYuzde.SelectedItem.ToString();
                        string[] adSoyad = secilenPersonel.Split(' ');

                        string ad = adSoyad[0];// dizi 
                        string soyad = adSoyad[1];

                        int mevcutMaas = MevcutMaas(ad, soyad);
                        
                        int yeniMaas = mevcutMaas + (mevcutMaas * yuzde) / 100;

                        UpdateMaas(ad, soyad, yeniMaas);

                        MessageBox.Show("Maaş başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir yüzde değeri giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir personel seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
        private int MevcutMaas(string ad, string soyad)
        {
            int mevcutMaas = 0;

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT p_maas FROM personel WHERE p_ad = @ad AND p_soyad = @soyad", conn))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);

                    try
                    {
                        conn.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                mevcutMaas = Convert.ToInt32(reader["p_maas"]); // tür dönüşümü yapıldı ki işlem yapılsın
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message);
                    }
                }
            }

            return mevcutMaas;
        }
        private void UpdateMaas(string ad, string soyad, int yeniMaas)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand("UPDATE personel SET p_maas = @yeniMaas WHERE p_ad = @ad AND p_soyad = @soyad", conn))
                {
                    // burada kritik olan ilk önce set sorgusuna parametreler atanıyor ardından 
                    //parametrelere değerler atanır sonra conn açılır ve güncellerr 
                    // try catch kullanılması bu yüzdendir 
                    cmd.Parameters.AddWithValue("@yeniMaas", yeniMaas);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void btnNormalEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNormal.SelectedIndex != -1)
                {
                    if (int.TryParse(textBoxNormalEkle.Text, out int eklenecekMiktar))
                    {
                        string secilenPersonel = comboBoxNormal.SelectedItem.ToString();
                        string[] adSoyad = secilenPersonel.Split(' ');

                        string ad = adSoyad[0];
                        string soyad = adSoyad[1];

                        int mevcutMaas = MevcutMaas(ad, soyad);
                        int yeniMaas = mevcutMaas + eklenecekMiktar;

                        UpdateMaas(ad, soyad, yeniMaas);

                        MessageBox.Show("Maaş başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir miktar giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir personel seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void btnNormalCıkar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNormal.SelectedIndex != -1)
                {
                    if (int.TryParse(textBoxNormalEkle.Text, out int cikarilacakMiktar))
                    {
                        string secilenPersonel = comboBoxNormal.SelectedItem.ToString();
                        string[] adSoyad = secilenPersonel.Split(' '); // boşluk koyarak diziye çevirme

                        string ad = adSoyad[0]; // dizinin ilk elemanı
                        string soyad = adSoyad[1];
                        // dizisiz ekleme yöntemi bul***************************************************************
                        int mevcutMaas = MevcutMaas(ad, soyad);
                        int yeniMaas = mevcutMaas - cikarilacakMiktar;

                        UpdateMaas(ad, soyad, yeniMaas);

                        MessageBox.Show("Maaş başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir miktar giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir personel seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
    }
}