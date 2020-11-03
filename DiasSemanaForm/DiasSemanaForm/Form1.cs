using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasSemanaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLunes_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnLunes.Text;
        }

        private void btnMartes_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnMartes.Text;
        }

        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnMiercoles.Text;
        }

        private void btnJueves_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnJueves.Text;
        }

        private void btnViernes_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnViernes.Text;
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnSabado.Text;
        }

        private void btnDomingo_Click(object sender, EventArgs e)
        {
            lblDias.Text = btnDomingo.Text;
        }
    }
}
