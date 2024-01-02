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
    public partial class MaasIsleri : Form
    {
        public MaasIsleri()
        {
            InitializeComponent();
            panelYuzde.Visible = false;
            panelNormal.Visible = false;
        }
      
     
        private void MaasIsleri_Load(object sender, EventArgs e)
        {

        }

        private void labelNormalPersonel_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonYuzde_CheckedChanged_1(object sender, EventArgs e)// radiobuton seçme
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

        private void radioButtonNormal_CheckedChanged_1(object sender, EventArgs e)
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
