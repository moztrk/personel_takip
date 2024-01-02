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

            panelYuzde.Visible = false;
            panelNormal.Visible = false;
            ComboBoxYuzdeDoldur();
            ComboBoxNormalDoldur();
        }


        private void MaasIsleri_Load(object sender, EventArgs e)
        {

        }

     


       
        private void ComboBoxYuzdeDoldur()
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
                                    comboBoxYuzde.Items.Add($"{ad} {soyad}");
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

                        using (OleDbCommand command = new OleDbCommand(query, conn))
                        {
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

                // Diğer paneli gizle
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

                // Diğer paneli gizle
                if (panelYuzde.Visible)
                {
                    panelYuzde.Visible = false;
                }
            }
        }
    }
}