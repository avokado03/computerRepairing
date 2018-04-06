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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm lf = new LogInForm();
            lf.Show();
            Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            rf.Show();
            Hide();
        }
    }
}
