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
    public partial class PaginaUserComun : Form
    {
        public PaginaUserComun()
        {
            InitializeComponent();
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
            FormLeitura a = new FormLeitura();
            a.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
