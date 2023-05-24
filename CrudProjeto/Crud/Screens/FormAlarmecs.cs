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
    public partial class FormAlarme : Form
    {
        public FormAlarme()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormPaginaPrincipal p = new FormPaginaPrincipal();
            p.ShowDialog();


        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            AlarNivel a = new AlarNivel();
            a.ShowDialog();
        }

        private void btnBomba_Click(object sender, EventArgs e)
        {
            AlarBomba b = new AlarBomba();
            b.ShowDialog();
        }

        private void btnPon_Click(object sender, EventArgs e)
        {
            AlarPonto p = new AlarPonto();
            p.ShowDialog();
        }
    }
}
