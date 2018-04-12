using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace computerRepairing
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iluhaDataSet1.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.iluhaDataSet1.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iluhaDataSet1.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.iluhaDataSet1.Услуги);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.услугиTableAdapter.Fill(this.iluhaDataSet1.Услуги);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClientMenuForm cfm = new ClientMenuForm();
            cfm.Show();
            Close();
        }
    }
}
