using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hardyApp
{
    public partial class Form1 : Form
    {
        String ip = "192.168.0.52";
        private double pesoHardy = 0;
        List<double> ListaPesos;
        public Form1()
        {
            InitializeComponent();
            var TrabajoPrueba = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
        }

        private void btnPesar_Click(object sender, EventArgs e)
        {
            


            if (btnPesar.Text == "Iniciar Pesaje")
            {

                btnPesar.Text = "Detener";
                
                backgroundWorker1.RunWorkerAsync();
                
            } 
            else
            {
                btnPesar.Text = "Iniciar Pesaje";
                backgroundWorker1.CancelAsync();
                backgroundWorker1.RunWorkerCompleted += TrabajoCompletado;
                
            }
            //double pesoHardy = Hardy.pesohardy(ip);
            //lblPesoHardy.Text = "Peso en gr = " + pesoHardy.ToString();
            // metodo para ejecutar tareas en segundo plano

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            
            // metodo para ejecutar tareas en segundo plano
            //backgroundWorker1.RunWorkerAsync();
            string calibracion = Hardy.Calibracion_C2(ip);
            lblPesoHardy.Text = "calibración = " + calibracion;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //bool ObjPresiono = (bool)e.Argument;
            ListaPesos = new List<double>();
            while (!backgroundWorker1.CancellationPending)
            {
                pesoHardy = Hardy.pesohardy(ip);
                //Console.WriteLine(pesoHardy);
                //lblPesoHardy.Text = "Peso" + pesoHardy;
                //Console.WriteLine(pesoHardy);
                ListaPesos.Add(pesoHardy);
                //Object ObjPeso = pesoHardy;

                backgroundWorker1.ReportProgress(1);

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Double ObjPeso = (double)e.UserState;
            lblPesoHardy.Text = "Peso " + pesoHardy;
            //if (e.ProgressPercentage == 1)
            //{

            //    lblPesoHardy.Text = "Peso Máximo = " + ListaPesos.Max();
            //}
        }

        public void TrabajoCompletado(object sender, RunWorkerCompletedEventArgs e)
        {
            // Si terminó el trabajo (finalización, cancelación, error), hacer lo siguiente:
            Console.WriteLine();
            Console.WriteLine("Finaliza el Trabajo de prueba");
            lblPesoHardy.Text = "Peso Máximo = " + ListaPesos.Max();
        }
    }
}
