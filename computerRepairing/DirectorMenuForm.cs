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
    public partial class DirectorMenuForm : Form
    {
        public DirectorMenuForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.roleUser = "";
            Properties.Settings.Default.idUser = 0;
            LogInForm lf = new LogInForm();
            lf.Show();
            Close();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            AddPositionForm apf = new AddPositionForm();
            apf.Show();
            Close();
        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            EditPositionForm epf = new EditPositionForm();
            epf.Show();
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
            Close();
        }
    }
}
