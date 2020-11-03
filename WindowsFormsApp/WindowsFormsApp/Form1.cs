using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnCero.Text;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnUno.Text;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text = btnPunto.Text;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnDos.Text;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnTres.Text;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnCuatro.Text;
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnCinco.Text;
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnSeis.Text;
        }
        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnSiete.Text;
        }
        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnOcho.Text;
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnNueve.Text;
        }

        private void btnCinco_Click_1(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnCinco.Text;
        }

        private void btnSeis_Click_1(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnSeis.Text;
        }

        private void btnOcho_Click_1(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnOcho.Text;
        }

        private void btnNueve_Click_1(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length < 12)
                lblPantalla.Text += btnNueve.Text;
        }
    }
}
