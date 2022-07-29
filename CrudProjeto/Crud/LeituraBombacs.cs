using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class LeituraBombacs : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter da;
        private string strSQL;
        public LeituraBombacs()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormPaginaPrincipal principal = new FormPaginaPrincipal();
            principal.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "INSERT INTO leitura_bomba (NOME, STATUS, DATA_E_HORA) VALUES ( @NOME, @STATUS, @DATA_E_HORA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@Status", txtStatus.Text);
                comando.Parameters.AddWithValue("@Data_e_hora", dateTimePicker1.Value);

                conexao.Open();
                MessageBox.Show("Bomba Cadastrada!");
                comando.ExecuteNonQuery();
                GetPonto();

                txtNome.Clear();
                txtStatus.Clear();


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
            strSQL = ("SELECT * FROM leitua_bomba ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from leitura_bomba", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "leitura_bomba");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "leitura_bomba";
            conexao.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void LeituraBombacs_Load(object sender, EventArgs e)
        {
            GetPonto();
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
                    using (DataTable dt = new DataTable())
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
