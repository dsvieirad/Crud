using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;



namespace Crud
{
    public partial class LoginPage : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dr;
        private string strSQL;
        private int ID;

        public LoginPage()
        {
            InitializeComponent();
        }
        private void buttonCancelar_Click(object sender, EventArgs e) => Application.Exit();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                connection = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = $"SELECT * FROM CAD_USER WHERE Email='{txtEmail.Text}' AND Senha='{txtSenha.Text}'";
                connection.Open();
                command = new MySqlCommand(strSQL, connection);
                command.CommandText = strSQL;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    login = new Login
                    {
                        Email = dr["Email"].ToString(),
                        Senha = dr["Senha"].ToString(),
                    };
                }
                if (login.Email != null && login.Senha != null)
                {
                    command.BeginExecuteNonQuery();

                    FormPaginaPrincipal p = new FormPaginaPrincipal();
                    p.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro ao fazer login!", "Atenção! Preencha os campos!",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                command = null;

            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.ForeColor = Color.Crimson;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Crimson; 
        }
    }
}
