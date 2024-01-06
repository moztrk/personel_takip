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
    public partial class MesaiIsleri : Form
    {
        public MesaiIsleri()
        {
            InitializeComponent();
            ComboBoxMesaiDoldur();
            ComboBoxMsaatiDoldur();
        }
       
        private void ComboBoxMesaiDoldur()
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GirisEkranı.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT p_ad, p_soyad FROM personel", conn))
                {
                    try
                    {
                        conn.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ad = reader["p_ad"].ToString();
                                string soyad = reader["p_soyad"].ToString();
                                comboBoxMesai.Items.Add($"{ad} {soyad}");
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

        private void ComboBoxMsaatiDoldur()
        {
            // ComboBoxMsaati'yi 1, 2, 3, 4 değerleriyle doldur
            for (int i = 1; i <= 24; i++)
            {
                comboBoxMsaati.Items.Add(i);
            }
        }

        private void btnMekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Mesai ekle sekmesinden seçilen değerleri al
                string secilenPersonel = comboBoxMesai.SelectedItem?.ToString();
                int secilenSaat = Convert.ToInt32(comboBoxMsaati.SelectedItem);

                if (string.IsNullOrEmpty(secilenPersonel) || secilenSaat == 0)
                {
                    MessageBox.Show("Lütfen geçerli bir personel ve saat seçin.");
                    return;
                }

                // Seçilen personel adını ve soyadını ayır
                string[] adSoyad = secilenPersonel.Split(' ');
                string ad = adSoyad[0];
                string soyad = adSoyad[1];

                // Personelin saatlik ücretini al
                double saatlikUcret = GetSaatlikUcret(ad, soyad);

                // Prim hesapla ve personel tablosunda güncelle
                double prim = saatlikUcret * secilenSaat;
                UpdatePrim(ad, soyad, prim);

                MessageBox.Show("Prim başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
        private double GetSaatlikUcret(string ad, string soyad)
        {
            double saatlikUcret = 0;

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT m_saatlikucret FROM mesai ", conn))
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
                                saatlikUcret = Convert.ToDouble(reader["m_saatlikucret"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message);
                    }
                }
            }

            return saatlikUcret;
        }
        private void UpdatePrim(string ad, string soyad, double prim)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand("UPDATE personel SET p_prim = p_prim + @prim WHERE p_ad = @ad AND p_soyad = @soyad", conn))
                {
                    cmd.Parameters.AddWithValue("@prim", prim);
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

        private void btnSıfırlama_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GirisEkranı.accdb"))
                {
                    using (OleDbCommand cmd = new OleDbCommand("UPDATE personel SET p_prim = 0, p_primyenilemetarihi = @tarih", conn))
                    {
                        DateTime tarih = DateTime.Now;
                        string yazisekli = tarih.ToString("dd/MM/yyyy");
                        string primsifirlama = yazisekli;

                        cmd.Parameters.AddWithValue("@tarih",primsifirlama );

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Prim sıfırlama işlemi başarıyla gerçekleştirildi.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }

        }

        private void btnMbilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // txtSaatUcretiM'den değeri al
                double yeniSaatUcreti = Convert.ToDouble(txtSaatUcretiM.Text);

                // UpdateMesaiBilgisi metodunu kullanarak güncelleme yap
                UpdateMesaiBilgisi(yeniSaatUcreti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
        private void LabelaYazdırMesaiUcreti()
        {

            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 m_saatlikucret FROM mesai ORDER BY m_degismetarihi DESC", conn))
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            double saatUcreti = Convert.ToDouble(result);
                            labelBilgi.Text = $"Mesai Saat Ücreti: {saatUcreti:C2}";
                        }
                        else
                        {
                            labelBilgi.Text = "Mesai saat ücreti bulunamadı.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }

        }
        private void UpdateMesaiBilgisi(double yeniSaatUcreti)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb"))
                {
                    using (OleDbCommand cmd = new OleDbCommand("UPDATE mesai SET m_saatlikucret = @saatUcreti, m_degismetarihi = @degisimTarihi", conn))
                    {
                        DateTime degisimTarihi = DateTime.Now;
                        string degisimTarihiString = degisimTarihi.ToString("dd/MM/yyyy");

                        cmd.Parameters.AddWithValue("@saatUcreti", yeniSaatUcreti);
                        cmd.Parameters.AddWithValue("@degisimTarihi", degisimTarihiString);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Mesai bilgileri başarıyla güncellendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            LabelaYazdırMesaiUcreti();
        }
    }

}
   


   

