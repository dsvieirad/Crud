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
    public partial class AlarPonto : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter da;
        private string strSQL;

        public AlarPonto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetPonto()
        {
            conexao = new MySqlConnection("server = 127.0.0.1;User Id=root;password=admin;database=crud");
            strSQL = ("SELECT * FROM alarme_ponto ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from alarme_ponto", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "alarme_ponto");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "alarme_ponto";
            conexao.Close();
        }

        private void AlarPonto_Load(object sender, EventArgs e)
        {
            GetPonto();
        }

        private void btnSula_Click(object sender, EventArgs e)
        {
            if(checkBoxSu.Checked == true)
            {
                MessageBox.Show("Ponto Ativo!");
                btnSula.BackColor = Color.Green;
            }
            else
            {
                btnSula.BackColor = Color.Red;
                MessageBox.Show("Ponto desativado.");
            }
        }

        private void btnSola_Click(object sender, EventArgs e)
        {
            if (checkBoxSo.Checked == true)
            {
                MessageBox.Show("Ponto Ativo!");
                btnSola.BackColor = Color.Green;    
            }
            else
            {
                btnSola.BackColor= Color.Red;
                MessageBox.Show("Ponto desativado.");
            }
        }

        private void btnRDS_Click(object sender, EventArgs e)
        {
            if(checkBoxRa.Checked == true)
            {
                MessageBox.Show("Ponto Ativo!");
                btnRDS.BackColor= Color.Green;
            }
            else
            {
                btnRDS.BackColor = Color.Red;
                MessageBox.Show("Ponto desativado.");
            }
        }
    }
}
