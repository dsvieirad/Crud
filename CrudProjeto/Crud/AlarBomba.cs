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
    
    public partial class AlarBomba : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter da;
        private string strSQL;
        public AlarBomba()
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
            strSQL = ("SELECT * FROM alarme_bomba ");
            conexao.Open();
            da = new MySqlDataAdapter("select * from alarme_bomba", conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "alarme_bomba");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "alarme_bomba";
            conexao.Close();
        }

        private void AlarBomba_Load(object sender, EventArgs e)
        {
            GetPonto();
        }
      

        private void btnSula_Click_1(object sender, EventArgs e)
        {
            if (checkBoxSu.Checked == true)
            {
                MessageBox.Show("A bomba está ok!");
                btnSula.BackColor = Color.Green;
            }
            else
            {
                btnSula.BackColor = Color.Red;
                MessageBox.Show("Bomba desativada.");
            }
        }

        private void btnSola_Click_1(object sender, EventArgs e)
        {
            if (checkBoxSo.Checked == true)
            {
                MessageBox.Show("A bomba está ok!");
                btnSola.BackColor = Color.Green;
            }
            else
            {
                btnSola.BackColor = Color.Red;
                MessageBox.Show("Bomba desativada.");
            }
        }

        private void btnRDS_Click_1(object sender, EventArgs e)
        {
            if (checkBoxRa.Checked == true)
            {
                MessageBox.Show("A bomba está ok!");
                btnRDS.BackColor = Color.Green;
            }
            else
            {
                btnRDS.BackColor = Color.Red;
                MessageBox.Show("Bomba desativada.");
            }
        }
    }
    
    
}
