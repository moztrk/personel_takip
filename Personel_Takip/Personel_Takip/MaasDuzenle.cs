using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
    public partial class MaasDuzenle : Form
    {
        public MaasDuzenle()
        {
            InitializeComponent();
          
        }

      

        private void Mbtnmenu_Click(object sender, EventArgs e)
        {
            Menu f1 = new Menu();
            f1.Show();
            this.Hide();
        }

        private void mbtnMaas_Click(object sender, EventArgs e)
        {
            panelFormAcma.Controls.Clear();
            MaasIsleri f2 = new MaasIsleri();
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            panelFormAcma.Controls.Add(f2);
            f2.Show();

        }

        private void MbtnMesai_Click(object sender, EventArgs e)
        {
            panelFormAcma.Controls.Clear();
            MesaiIsleri f = new MesaiIsleri();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelFormAcma.Controls.Add(f);
            f.Show();
        }
    }
}
