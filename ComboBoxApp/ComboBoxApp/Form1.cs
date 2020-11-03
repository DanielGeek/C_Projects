using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int f = 0; f <= 255; f++)
            {
                cBRojo.Items.Add(f.ToString());
                cBVerde.Items.Add(f.ToString());
                cBAzul.Items.Add(f.ToString());
            }
            cBRojo.SelectedIndex = 0;
            cBVerde.SelectedIndex = 0;
            cBAzul.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(cBRojo.Text);
            int verde = int.Parse(cBVerde.Text);
            int azul = int.Parse(cBAzul.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
