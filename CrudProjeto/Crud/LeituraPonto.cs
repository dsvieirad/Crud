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
using MySql.Data;



namespace Crud
{
    public partial class LeituraPonto : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter da;
        private string strSQL;
        public LeituraPonto()
        {
            InitializeComponent();
        }

        private void LeituraPonto_Load(object sender, EventArgs e)
        {
            GetPonto();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormPaginaPrincipal p = new FormPaginaPrincipal();
            p.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            string valid;
            valid = txtNome.Text.Trim(); txtTipo.Text.Trim(); txtStatus.Text.Trim();

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "INSERT INTO leitura_ponto (NOME, TIPO_PONTO, STATUS, DATA_E_HORA) VALUES ( @NOME, @TIPO_PONTO, @STATUS, @DATA_E_HORA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@Tipo_ponto", txtTipo.Text);
                comando.Parameters.AddWithValue("@Status", txtStatus.Text);
                comando.Parameters.AddWithValue("@Data_e_hora", dateTimePicker1.Value);

               if(valid == "")
                {
                    MessageBox.Show("Preencha os campos");
                    
                }
                else
                {
                    conexao.Open();
                    MessageBox.Show("Ponto Cadastrado!");
                    comando.ExecuteNonQuery();
                    GetPonto();

                    txtNome.Clear();
                    txtStatus.Clear();
                    txtTipo.Clear();
                }


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
        }

        public void GetPonto()
        {
            conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
            strSQL = ("SELECT * FROM leitua_ponto ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from leitura_ponto", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "leitura_ponto");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "leitura_ponto";
            conexao.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando aguarde!";
            statusStrip1.Refresh();

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                conexao.Open(); 
                strSQL = ("SELECT * FROM leitura_ponto WHERE NOME = '" + txtBuscar.Text + "'");
                using (MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conexao))
                {
                    using(DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }
                toolStripStatusLabel1.Text = "Conectado";
                statusStrip1.Refresh();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            statusStrip1.Refresh();
        }
    }
}
