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
    public partial class EditPositionForm : Form
    {
        private int idPos;
        public EditPositionForm()
        {
            InitializeComponent();
        }

        private void EditPositionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iluhaDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.iluhaDataSet.Услуги);

        }
        //отображение информации о выбранной услуге
        private void comboBoxChoosePose_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPos = Convert.ToInt32(comboBoxChoosePose.SelectedValue);
            textBoxNamePos.Text = iluhaDataSet.Услуги.Where(i=>i.id_Услуги==idPos)
                .Select(i => i.Наименование).SingleOrDefault().ToString();
            textBoxDescPos.Text = iluhaDataSet.Услуги.Where(i => i.id_Услуги == idPos)
                .Select(i => i.Описание).SingleOrDefault().ToString();
            textBoxPricePos.Text = iluhaDataSet.Услуги.Where(i => i.id_Услуги == idPos)
                .Select(i => i.Стоимость_работы).SingleOrDefault().ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString)) {
                string namePos, descriptionPos;
                float pricePos;
                try
                {
                    namePos = textBoxNamePos.Text;
                    descriptionPos = textBoxDescPos.Text;
                    pricePos = Convert.ToSingle(textBoxPricePos.Text);
                    string updQuery = "UPDATE [Услуги] SET [Наименование]='" + namePos
                        + "',[Описание]='" + descriptionPos + "',[Стоимость_Работы]=" + pricePos+"WHERE [id_Услуги]="+idPos;
                    connection.Open();
                    SqlCommand updCmd = new SqlCommand(updQuery, connection);
                    updCmd.ExecuteNonQuery();
                    MessageBox.Show("Услуга успешно изменена!");
                }
                catch (Exception ex) {
                    MessageBox.Show("Database Error" + ex);
                }
            }
        }
    }
}
