using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;




namespace Crud
{
    public partial class FormUsuario : Form
    {
       private MySqlConnection conexao;
       private MySqlCommand comando;
       private MySqlDataAdapter da;
       private string strSQL;

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string valid;
            valid = textBoxNome.Text.Trim(); textBoxEmail.Text.Trim(); textBoxSenha.Text.Trim();

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "INSERT INTO CAD_USER (NOME, EMAIL, SENHA, TIPO_DE_USER) VALUES ( @NOME, @EMAIL, @SENHA, @TIPO_DE_USER)";
                comando = new MySqlCommand(strSQL,conexao);
                comando.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                comando.Parameters.AddWithValue("@Senha", textBoxSenha.Text);
                comando.Parameters.AddWithValue("@Tipo_de_user", textBox1.Text);
               
                // impede o cadastro dos campos vazios
                if(valid == "")
                {
                    MessageBox.Show("Preencha os campos!");
                   
                }
                else
                {
                    conexao.Open();
                    MessageBox.Show("Usuario criado!");
                    comando.ExecuteNonQuery();
                    GetPonto();

                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    textBoxSenha.Clear();
                    textBox1.Clear();
                }
              


            }
            catch(MySqlException exp)
            {
                MessageBox.Show(exp.Message);
                MessageBox.Show("Não conectado");
            }
            finally
            {
                conexao.Close();
                conexao=null;
                comando=null;
            }

           

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormPaginaPrincipal p = new FormPaginaPrincipal();
            p.ShowDialog();
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            
            string valid;
            valid = textBoxNome.Text.Trim(); 
            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "DELETE FROM CAD_USER  WHERE Nome= @Nome";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", textBoxNome.Text);

                if (valid == "")
                {
                    MessageBox.Show("Preencha os campos!");

                }
                else
                {
                    conexao.Open();
                    MessageBox.Show("Usuario criado!");
                    comando.ExecuteNonQuery();
                    GetPonto();

                    textBoxNome.Clear();
                    
                }

            }
            catch
            {
                MessageBox.Show("Não conectado");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            string valid;
            valid = textBoxNome.Text.Trim(); 

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "UPDATE CAD_USER SET EMAIL = @EMAIL, SENHA = @SENHA WHERE Nome= @Nome";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                comando.Parameters.AddWithValue("@Senha", textBoxSenha.Text);

                if (valid == "")
                {
                    MessageBox.Show("Preencha os campos!");

                }
                else
                {
                    conexao.Open();
                    MessageBox.Show("Usuario criado!");
                    comando.ExecuteNonQuery();
                    GetPonto();

                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    textBoxSenha.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Não conectado");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        public void GetPonto()
        {
            //exibe os dados atualizados na tebela a cada nova ação
            conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
            strSQL = ("SELECT * FROM CAD_USER ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from cad_user", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "cad_user");
            dataGridViewUser.DataSource = ds;
            dataGridViewUser.DataMember = "cad_user";
            conexao.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
             GetPonto();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // função de seleção e auto incremento os campos.
            int select_row;
            if (e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow data = dataGridViewUser.Rows[select_row];
                textBoxNome.Text = data.Cells[0].Value.ToString();
                textBoxEmail.Text = data.Cells[1].Value.ToString();
                textBoxSenha.Text = data.Cells[2].Value.ToString();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
