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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Crud
{
    public partial class LeituraVazao : Form
    {

        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter da;
        private string strSQL;
        public LeituraVazao()
        {
            InitializeComponent();
        }

        private void LeituraVazao_Load(object sender, EventArgs e)
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

            try
            {

                string valid;
               
                valid =textBox1.Text.Trim(); txtVazao.Text.Trim();txtVolume.Text.Trim(); txtStatus.Text.Trim();

                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                strSQL = "INSERT INTO leitura_vazao (NOME,VAZAO, VOLUME, STATUS, DATA_E_HORA) VALUES ( @NOME, @VAZAO, @VOLUME, @STATUS, @DATA_E_HORA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", textBox1.Text);
                comando.Parameters.AddWithValue("@Vazao", txtVazao.Text);
                comando.Parameters.AddWithValue("@Volume", txtVolume.Text);
                comando.Parameters.AddWithValue("@Status", txtStatus.Text);
                comando.Parameters.AddWithValue("@Data_e_hora", dateTimePicker1.Value);

                if(valid == "")
                {
                    MessageBox.Show("Preencha os campos");
            

                }
                else
                {
                    conexao.Open();
                    MessageBox.Show("Vazão Cadastrada!");
                    comando.ExecuteNonQuery();
                    GetPonto();

                    txtVazao.Clear();
                    txtStatus.Clear();
                    txtVolume.Clear();
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
            strSQL = ("SELECT * FROM leitua_vazao ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from leitura_vazao", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "leitura_vazao");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "leitura_vazao";
            conexao.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Conectando aguarde!";
            statusStrip1.Refresh();

            try
            {
                conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
                conexao.Open();
                strSQL = ("SELECT * FROM leitura_vazao WHERE NOME = '" + txtBuscar.Text + "'");
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
