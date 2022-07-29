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
    public partial class PaginaPComun : Form
    {
        public PaginaPComun()
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
            FormLeitura l = new FormLeitura();
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
