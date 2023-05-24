using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormPaginaPrincipal : Form
    {
        public FormPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormUsuario u = new FormUsuario();
            u.ShowDialog();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            FormUsuario user = new FormUsuario();
            user.ShowDialog();
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            FormPPonto p = new FormPPonto();
            p.ShowDialog();
        }

        private void buttonAlarme_Click(object sender, EventArgs e)
        {
            FormAlarme a = new FormAlarme();
            a.ShowDialog();
        }

        private void buttonLeitura_Click(object sender, EventArgs e)
        {
            FormLeitura l = new FormLeitura();
            l.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormAlarme a = new FormAlarme();
            a.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormLeitura l = new FormLeitura();
            l.ShowDialog();
        }
    }
}
