using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaAppForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtBValor1.TextLength < 1 || txtBValor2.TextLength < 1)
            {
                MessageBox.Show("Debe ingresar un número en cada campo");
                return;
            }
            int valor1 = int.Parse(txtBValor1.Text);
            int valor2 = int.Parse(txtBValor2.Text);
            
            int suma = valor1 + valor2;
            lblResultado.Text += suma.ToString();
        }
    }
}
