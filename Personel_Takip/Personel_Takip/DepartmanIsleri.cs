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
            
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu f1 = new Menu();
            f1.Show();  
            this.Hide();
        }
    }
}
