﻿using System;
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
    }
}
