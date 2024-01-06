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
        public DepartmanIsleri()
        {
            InitializeComponent();
            panelYonetim.Visible = false;
            panelYonetimMaas.Visible = false;
            panelMuhasebe.Visible = false;
            panelSekreterlik.Visible = false;
            panelPazarlama.Visible = false;
            panelUretim.Visible = false;
            panelLojistik.Visible = false;
           
        }

        private void btnYmenu_Click(object sender, EventArgs e)
        {
            MenuDon();
        }
        private void MenuDon()
        {
            Menu f1 = new Menu();
            f1.Show();
            this.Hide();
        }

        private void btnMmenu_Click(object sender, EventArgs e)
        {
            MenuDon();
        }

        private void btnSmenu_Click(object sender, EventArgs e)
        {
            MenuDon();
        }

        private void btnPmenu_Click(object sender, EventArgs e)
        {
            MenuDon();
        }

        private void btnUmenu_Click(object sender, EventArgs e)
        {
            MenuDon();
        }

        private void btnLmenu_Click(object sender, EventArgs e)
        {
            MenuDon();
        }

        private void DepartmanIsleri_Load(object sender, EventArgs e)
        {
        
        }

        private void btnKapasite_Click(object sender, EventArgs e)
        {
           


        }
       

      

        private void btnYkapasitearttır_Click(object sender, EventArgs e)
        {
           


        }

        private void btnYkapasiteDusur_Click(object sender, EventArgs e)
        { 
        
        
        }
           
    }
}
