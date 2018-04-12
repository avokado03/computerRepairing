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
    public partial class ClientMenuForm : Form
    {
        public ClientMenuForm()
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

        private void btnShowCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm cf = new CatalogForm();
            cf.Show();
            Close();
        }

        private void btnSetPosition_Click(object sender, EventArgs e)
        {
            SetPositionForm spf = new SetPositionForm();
            spf.Show();
            Close();
        }
    }
}
