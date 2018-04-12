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
    public partial class ReportForm : Form
    {
        public ReportForm()
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
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    DateTime from = dateTimePicker1.Value;
                    DateTime to = dateTimePicker2.Value;
                    double price = 0;
                    from.ToShortDateString();
                    to.ToShortDateString();
                    string query = "select [id_Заказчик],[id_Мастер],[Дата],[Цена]" +
                        " from [Заказ]" +
                        " where [Дата] between '" + from +
                        "' and '" + to + "'";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvSetPosition.DataSource = dt;
                        for (int i = 0; i < dt.Rows.Count; i++) {
                            price += Convert.ToDouble(dgvSetPosition[3,i].Value);
                        }                        
                        label4.Text = "Выручка за период: " + price.ToString();
                    }
                    else {
                        MessageBox.Show("Заказов в данном диапазоне не найдено");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Ошибка базы данных!"+ex);
                }
            }
        }
    }
}
