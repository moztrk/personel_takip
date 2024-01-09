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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        static public string yetki;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;

      

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dogrulama dogrulama = new Dogrulama();
            dogrulama.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = girisButton;
            this.CancelButton = cikisButton;
        }

        private void girisButton_Click(object sender, EventArgs e)
        {

            string ad = tkullanıcı.Text;
            string sifre = tsifre.Text;
            conn = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source=GirisEkranı.accdb");
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM login where k_adi = '" + tkullanıcı.Text + "' AND k_sifre = '" + tsifre.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Menu f2 = new Menu();
                f2.Show();
                this.Hide();
                yetki = reader["k_yetki"].ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz!!!");
            }
            conn.Close();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak  istediğinize emin misiniz?", "Uyarı"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // messagebox icon  ünlem 
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
