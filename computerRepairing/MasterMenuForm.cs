using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computerRepairing
{
    public partial class MasterMenuForm : Form
    {
        public MasterMenuForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            GetPositionForm gpf = new GetPositionForm();
            gpf.Show();
            Close();
        }

        private void btnShowMyPositon_Click(object sender, EventArgs e)
        {
            ShowOrderMasterForm somf = new ShowOrderMasterForm();
            somf.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.roleUser = "";
            Properties.Settings.Default.idUser = 0;
            LogInForm lf = new LogInForm();
            lf.Show();
            Close();
        }
    }
}
