using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Text = "";
            if (cBIngles.Checked == true)
            {
                Text += " " + cBIngles.Text + " ";
            }
            if (cBFrances.Checked == true)
            {
                Text += " " + cBFrances.Text + " ";
            }
            if (cBAleman.Checked == true)
            {
                Text += " " + cBAleman.Text + " ";
            }
        }

        private void cBAcepto_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAcepto.Checked == true)
            {
                btnMostrar.Enabled = true;
            }
            else
            {
                btnMostrar.Enabled = false;
            }
        }
    }
}
