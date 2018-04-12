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
    public partial class GetPositionForm : Form
    {
        private List<int> id;
        public GetPositionForm()
        {
            InitializeComponent();
            id = new List<int>();
        }

        private void GetPositionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iluhaDataSet1.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.iluhaDataSet1.Заказ);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MasterMenuForm mmf = new MasterMenuForm();
            mmf.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = !Convert.ToBoolean(dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                if (Convert.ToBoolean(dataGridView1[e.ColumnIndex, e.RowIndex].Value))
                {
                    id.Add(Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
                }
                else
                    id.Remove(Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString)) {
                try
                {
                    string query = "";
                    connection.Open();
                    foreach (int i in id)
                    {
                        query = "update [Заказ] set [id_Мастер]=" + Properties.Settings.Default.idUser
                            + " where [id_Заказ]=" + i;
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Заказы приняты!");
                }
                catch {
                    MessageBox.Show("Ошибка базы данных!");
                }
                }
            }
        }
    }

