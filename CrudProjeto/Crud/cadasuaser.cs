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
using System.Security;



namespace Crud
{
    public partial class cadasuaser : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter da;
        private string strSQL;


        public cadasuaser()
        {
            InitializeComponent();
        }



        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "INSERT INTO CAD_USER (NOME, EMAIL, SENHA) VALUES ( @NOME, @EMAIL, @SENHA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                comando.Parameters.AddWithValue("@Senha", maskedTextBox1.Text);
                

                conexao.Open();
                MessageBox.Show("Usuario criado!");
                comando.ExecuteNonQuery();


                textBoxNome.Clear();
                textBoxEmail.Clear();
              

            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
                MessageBox.Show("Não conectado");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            LoginPage l = new LoginPage();
            l.ShowDialog();




        }



    }

}