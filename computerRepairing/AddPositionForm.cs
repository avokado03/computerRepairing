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
    public partial class AddPositionForm : Form
    {
        public AddPositionForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DirectorMenuForm dmf = new DirectorMenuForm();
            dmf.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString)) {
                string namePos, descriptionPos;
                float pricePos;
                try
                {
                    namePos = textBoxNamePos.Text;
                    descriptionPos = textBoxDescPos.Text;
                    pricePos = Convert.ToSingle(textBoxPricePos.Text);
                    string insQuery = "INSERT INTO [Услуги] VALUES ('" + namePos + "','" + descriptionPos + "','" + pricePos + "')";
                    connection.Open();
                    SqlCommand insCommand = new SqlCommand(insQuery, connection);
                    insCommand.ExecuteNonQuery();
                    MessageBox.Show("Услуга успешно добавлена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error"+ex);
                }
            }
        }
    }
}
