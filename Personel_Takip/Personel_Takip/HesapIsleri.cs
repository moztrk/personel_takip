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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;

namespace Personel_Takip
{
    public partial class HesapIsleri : Form
    {
        string baglanti = "Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb";

        public HesapIsleri()
        {    

            InitializeComponent();
            comboBoxHesap_Doldur(null,null);

        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;


        private void comboBoxHesap_Doldur(object sender, EventArgs e)
        {
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            for (int i = 1; i <= 12; i++)
            {
                comboBoxHesap.Items.Add(aylar[i - 1]);
            }
        }
        private void buttonRaporla_Click(object sender, EventArgs e)
        {
            if (comboBoxHesap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ay seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int digerGider;
            int gelir;
            string secilenAy = comboBoxHesap.SelectedItem.ToString();
            try
            {
                digerGider = int.Parse(textBoxGider.Text);
                gelir = int.Parse(textBoxGelir.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"secilenAy: {secilenAy}, digerGider: {digerGider}, gelir: {gelir}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // güncelleme
            HesapTablosuGuncelle(secilenAy,digerGider,gelir);


        }
        public static int ToplamMaasGider( )
        {
        
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            string sorgu = "SELECT SUM(p_maas) FROM personel";
            OleDbCommand cmd = new OleDbCommand(sorgu, conn);
            conn.Open();
            int toplam = cmd.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(cmd.ExecuteScalar()) : 0;
            conn.Close();
            return toplam;
        }

        public static int ToplamPrimGider( )
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            string sorgu = "SELECT SUM(p_prim) FROM personel";
            OleDbCommand cmd = new OleDbCommand(sorgu, conn);
            conn.Open();
          
            int toplam = cmd.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(cmd.ExecuteScalar()) : 0;
            conn.Close();
            return toplam;
        }
        private void HesapTablosuGuncelle(string secilenAy, int digerGider, int gelir)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");

            try
            {
                conn.Open();

             
                int toplamMaasGider = ToplamMaasGider();
                int toplamPrimGider = ToplamPrimGider();

                
                string sorgu = "INSERT INTO hesap (h_ay, h_maasgideri, h_primgider, h_toplamgider, h_digergider, h_gelir) " +
                  "VALUES (@Ay, @MaasGider, @PrimGider, @ToplamGider, @DigerGider, @Gelir)";


              
                int toplamGider = toplamMaasGider + toplamPrimGider;
                OleDbCommand cmd = new OleDbCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@Ay", secilenAy.ToString());
                cmd.Parameters.AddWithValue("@MaasGider", toplamMaasGider.ToString());
                cmd.Parameters.AddWithValue("@PrimGider", toplamPrimGider.ToString());
                cmd.Parameters.AddWithValue("@toplamgider", toplamGider.ToString());
                cmd.Parameters.AddWithValue("@DigerGider", digerGider.ToString());
                cmd.Parameters.AddWithValue("@Gelir", gelir.ToString());
               int deger= cmd.ExecuteNonQuery();
                if (deger==0)
                {
                    MessageBox.Show("hata");
                }
               
                MessageBox.Show("Hesap tablosu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
            
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               // kontrol et ve açıksa kapat
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

        }

        private void buttonGeridon_Click(object sender, EventArgs e)
        {
            DepartmanIsleri departmanIsleri = new DepartmanIsleri();
            departmanIsleri.Show();
            this.Hide();
        }
      
        void Listele()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            OleDbDataAdapter adp = new OleDbDataAdapter(selectCommandText: "SELECT * FROM hesap ", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewHesap.DataSource = dt;





        }
       
        private void HesapIsleri_Load(object sender, EventArgs e)
        {
            Listele();
            dataGridViewHesap.Columns["h_no"].HeaderText = "Numara";
            dataGridViewHesap.Columns["h_ay"].HeaderText = "Ay";
            dataGridViewHesap.Columns["h_maasgideri"].HeaderText = "Maaş Gİderi";
            dataGridViewHesap.Columns["h_primgider"].HeaderText = "Prim Gideri";
            dataGridViewHesap.Columns["h_toplamgider"].HeaderText = "Toplam Gider";
            dataGridViewHesap.Columns["h_digergider"].HeaderText = "Diğer Giderler";
            dataGridViewHesap.Columns["h_gelir"].HeaderText = "Gelir";

        }
    }
        
        }



