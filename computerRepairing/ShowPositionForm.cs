﻿using System;
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
    public partial class ShowPositionForm : Form
    {
        public ShowPositionForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClientMenuForm cfm = new ClientMenuForm();
            cfm.Show();
            Close();
        }

        private void ShowPositionForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "select z.id_Заказ as Номер,z.id_Мастер as Мастер,z.Дата,u.Наименование,u.Стоимость_работы as Цена" +
                    " from [Заказ] as z inner join [Заказанные услуги] as zu on z.id_Заказ=zu.id_Заказ" +
                    " inner join [Услуги] as u on zu.id_Услуга=u.id_Услуги" +
                    " where z.id_Заказчик=" + Properties.Settings.Default.idUser;
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                    else {
                        MessageBox.Show("Заказы не найдены");
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Ошибка бд!" + ex);
                }
            }
            
        }
    }
}
