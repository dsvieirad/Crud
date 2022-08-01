using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Crud
{
    public partial class FormPPonto : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        string strSQL;

        public FormPPonto()
        {

            InitializeComponent();
        }
     
        private void buttonFazerCadas_Click(object sender, EventArgs e)
        {
            try
            {
                string valid;
                valid = textBoxIP.Text.Trim(); textBoxPorta.Text.Trim(); textBoxNoDPon.Text.Trim(); txtTipo.Text.Trim();

                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "INSERT INTO PONTO ( IP, PORTA, NOME_DO_PONTO, TIPO_DE_PONTO) VALUES ( @IP, @PORTA, @NOME_DO_PONTO, @TIPO_DE_PONTO)";
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@IP",textBoxIP.Text);
                comando.Parameters.AddWithValue("@Porta",textBoxPorta.Text);
                comando.Parameters.AddWithValue("@Nome_do_ponto",textBoxNoDPon.Text);
                comando.Parameters.AddWithValue("@Tipo_de_ponto",txtTipo.Text);
                
                // impede que o cadastro seja realizado com os campos vazios.
                if(valid == "")
                {
                    MessageBox.Show("Preencha os dados");
                
                }
                else
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado!");
                    GetPonto();
                }
               

            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
          
            textBoxIP.Clear();
            textBoxPorta.Clear();
            textBoxNoDPon.Clear();
            txtTipo.Clear();
                
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "DELETE FROM PONTO  WHERE IP = @IP";
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@IP", textBoxIP.Text);
                MessageBox.Show("Ponto Deletado!");
                comando.ExecuteNonQuery();
                GetPonto();
                
            }
            catch
            {
                MessageBox.Show("Ponto não encontrado");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "UPDATE PONTO SET PORTA = @PORTA, NOME_DO_PONTO = @NOME_DO_PONTO, TIPO_DE_PONTO = @TIPO_DE_PONTO WHERE IP = @IP";
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@IP", textBoxIP.Text);
                comando.Parameters.AddWithValue("@Porta", textBoxPorta.Text);
                comando.Parameters.AddWithValue("@Nome_do_ponto", textBoxNoDPon.Text);
                comando.Parameters.AddWithValue("@Tipo_de_ponto", txtTipo.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Ponto Atualizado!");
                GetPonto();
            }
            catch
            {
                MessageBox.Show("Erro ao Atualizar o ponto!");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormPaginaPrincipal p = new FormPaginaPrincipal();
            p.ShowDialog();

        }

        private void FormCadasPonto_Load(object sender, EventArgs e)
        {
            GetPonto();
           
        }
        public void GetPonto()
        {   //função para exibir os dados atualiazados em tempo real na tabela
            conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
            strSQL = ("SELECT * FROM PONTO ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from ponto", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "ponto");
            PontodataGridView1.DataSource=ds;
            PontodataGridView1.DataMember = "ponto";
            conexao.Close();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PontodataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //permite selecionar uma determinada linha no datagridview
            int select_row;
            if(e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow data = PontodataGridView1.Rows[select_row];
                textBoxIP.Text = data.Cells[0].Value.ToString();
                textBoxPorta.Text = data.Cells[1].Value.ToString();
                textBoxNoDPon.Text = data.Cells[2].Value.ToString();
                txtTipo.Text = data.Cells[3].Value.ToString();
                
            }
        }
    }

}
