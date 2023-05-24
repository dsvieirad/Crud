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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Crud
{
    public partial class FormLeitura : Form
    {


        public FormLeitura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPaginaPrincipal p = new FormPaginaPrincipal();
            p.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLeitura_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBomba_Click(object sender, EventArgs e)
        {
            LeituraBombacs b = new LeituraBombacs();
            b.ShowDialog();
        }

        private void btnVazao_Click(object sender, EventArgs e)
        {
            LeituraVazao vazao = new LeituraVazao();
            vazao.ShowDialog();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            LeituraPonto P = new LeituraPonto();
            P.ShowDialog();
        }
    }

    
}
