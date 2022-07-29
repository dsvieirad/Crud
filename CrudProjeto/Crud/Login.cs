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
        
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader dr;
        private string strSQL;

        public LoginPage()
        {
            InitializeComponent();


        }
       
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            cadasuaser c = new cadasuaser();
            c.ShowDialog();  

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            { 
                
                CdasLogin login = new CdasLogin();
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = $"SELECT * FROM CAD_USER WHERE Email='{txtEmail.Text}' AND Senha='{txtSenha.Text}'";
                conexao.Open();
                comando = new MySqlCommand(strSQL, conexao);
                comando.CommandText = strSQL;
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    login = new CdasLogin
                    {
                        Email = dr["Email"].ToString(),
                        Senha = dr["Senha"].ToString(),
                    };
                }
                if (login.Email != null && login.Senha != null)
                {
                    MessageBox.Show("Você foi logado");

                    comando.BeginExecuteNonQuery();

                    FormPaginaPrincipal p = new FormPaginaPrincipal();
                    p.ShowDialog();

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando = null;

            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.txtEmail.Clear();
            this.txtSenha.Clear();
            Application.Exit();
        }


    }
}
