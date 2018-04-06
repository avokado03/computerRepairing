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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString)) {
                string login, password;
                try
                {
                    login = textBoxLogin.Text;
                    password = textBoxPas.Text;
                    connection.Open();
                    string loginQuery = "SELECT [Роль],[id_Пользователь] FROM [Пользователь] WHERE [Логин]='" +
                        login + "' AND [Пароль] COLLATE Cyrillic_General_CS_AS = '" + password + "'";
                    SqlCommand loginCmd = new SqlCommand(loginQuery, connection);
                    SqlDataReader loginReader = loginCmd.ExecuteReader();
                    if (loginReader.HasRows)
                    {
                        loginReader.Read();
                        Properties.Settings.Default.roleUser = loginReader.GetString(0);
                        Properties.Settings.Default.idUser = loginReader.GetInt32(1);
                        Form f=null;
                        switch (Properties.Settings.Default.roleUser) {
                            case "dir":
                                f = new DirectorMenuForm();
                                break;
                            case "mas":
                                f = new MasterMenuForm();
                                break;
                            case "cli":
                                f = new ClientMenuForm();
                                break;
                            default:
                                break;
                        }
                        f.Show();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error"+ex);
                }
            }
        }
    }
}
