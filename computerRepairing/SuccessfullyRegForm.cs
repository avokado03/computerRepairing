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
    public partial class SuccessfullyRegForm : Form
    {
        public SuccessfullyRegForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LogInForm lf = new LogInForm();
            lf.Show();
            Close();
        }
    }
}
