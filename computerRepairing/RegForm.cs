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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString)) {
                string login, password, name;
                try
                {
                    login = textBoxLogin.Text;
                    password = textBoxPass.Text;
                    name = textBoxName.Text;
                    string uQuery = "SELECT [Логин] FROM [Пользователь] WHERE [Логин]='"+login+"'";
                    string regQuery = "INSERT INTO [Пользователь] VALUES ('" + login + "','" + password + "','"
                        + name + "','cli')";
                    connection.Open();
                    SqlCommand uCmd = new SqlCommand(uQuery, connection);
                    SqlDataReader uReader = uCmd.ExecuteReader();
                    if (uReader.HasRows)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует!");
                        uReader.Close();
                    }
                    else {
                        uReader.Close();
                        SqlCommand regCmd = new SqlCommand(regQuery, connection);
                        regCmd.ExecuteNonQuery();
                        SuccessfullyRegForm srf = new SuccessfullyRegForm();
                        srf.Show();
                        Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("DatabaseError" + ex);
                }
            }
        }
    }
}
