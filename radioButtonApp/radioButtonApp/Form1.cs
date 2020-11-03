using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Width = 640;
                Height = 480;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    Width = 800;
                    Height = 600;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        Width = 1024;
                        Height = 768;
                    }
                }
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtB1.Text);
            int valor2 = int.Parse(txtB2.Text);
            if (rBSuma.Checked == true)
            {
                int suma = valor1 + valor2;
                Text = suma.ToString();
            }
            else
            {
                if (rBResta.Checked == true)
                {
                    int resta = valor1 - valor2;
                    Text = resta.ToString();
                }
            }
        }
    }
}
