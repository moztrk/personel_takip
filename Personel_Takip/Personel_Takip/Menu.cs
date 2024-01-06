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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;



        private void button1_Click(object sender, EventArgs e)
        {
            PersonelListesi form3 = new PersonelListesi();
            form3.Show();
            this.Hide();
          
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Giriş ekranına dönmek istediğinize emin misiniz?", "Uyarı"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // messagebox icon  ünlem 
            if (result == DialogResult.Yes)
            {
                GirisEkrani form1 = new GirisEkrani();
                form1.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle form4 = new PersonelEkle();
            form4.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            PersonelSil f1 = new PersonelSil();
            f1.Show();  
            this.Hide();
        }

        private void buttonMaas_Click(object sender, EventArgs e)
        {
            MaasDuzenle f1 = new MaasDuzenle();
            f1.Show();
            this.Hide();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanIsleri f4= new DepartmanIsleri();
            f4.Show();
            this.Hide();
        }
    }
}
