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
    public partial class SetPositionForm : Form
    {
        private float price;
        private List<int> id;
        public SetPositionForm()
        {
            InitializeComponent();
            price = 0;
            id = new List<int>();
        }

        private void SetPositionForm_Load(object sender, EventArgs e)
        {
            this.услугиTableAdapter.Fill(this.iluhaDataSet.Услуги);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClientMenuForm cmf = new ClientMenuForm();
            cmf.Show();
            Close();
        }

        private void dgvSetPosition_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //прости меня, боже, за этот костыль, по-другому не работает
        private void dgvSetPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex+1;
            if (e.ColumnIndex == 2)
            {
                dgvSetPosition[e.ColumnIndex, e.RowIndex].Value = !Convert.ToBoolean(dgvSetPosition[e.ColumnIndex, e.RowIndex].Value);
                if (Convert.ToBoolean(dgvSetPosition[e.ColumnIndex, e.RowIndex].Value))
                {
                    price += Convert.ToSingle(dgvSetPosition.Rows[e.RowIndex].Cells[1].Value);

                    id.Add(i);
                }
                else
                {
                    price -= Convert.ToSingle(dgvSetPosition.Rows[e.RowIndex].Cells[1].Value);
                    id.Remove(i);
                }
                label2.Text = "Общая стоимость " + price.ToString();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString)) {
                try
                {
                    int idClient = Properties.Settings.Default.idUser;
                    DateTime dt = DateTime.Now;
                    dt.ToShortDateString();
                    connection.Open();
                    string queryOrd = "INSERT INTO [Заказ] VALUES (" + idClient + ", NULL,'" + dt + "'," + price + ")";
                    SqlCommand cmdOrd = new SqlCommand(queryOrd, connection);
                    cmdOrd.ExecuteNonQuery();
                    string maxID = "SELECT MAX([id_Заказ]) FROM [Заказ]";
                    SqlCommand cmdMax = new SqlCommand(maxID, connection);
                    SqlDataReader reader = cmdMax.ExecuteReader();
                    int currentId = 0;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        currentId = reader.GetInt32(0);
                    }
                    reader.Close();
                    string queryIns = "";
                    foreach (int i in id) {
                        queryIns = "INSERT INTO [Заказанные услуги] VALUES (" + i + "," + currentId + ")";
                        SqlCommand cmdIns = new SqlCommand(queryIns, connection);
                        cmdIns.ExecuteNonQuery();
                    }
                    MessageBox.Show("Ваш заказ принят!");
                }
                catch (Exception ex) {
                    MessageBox.Show("Ошибка базы данных!"+ex);
                }
            }
        }
    }
}

