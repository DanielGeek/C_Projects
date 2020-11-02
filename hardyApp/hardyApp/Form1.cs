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
        private double pesoHardyMaximo = 0;
        List<double> ListaPesos;
        private int contador = 0;
        ConexionMysql conn = new ConexionMysql();
        public Form1()
        {
            InitializeComponent();

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
            ListaPesos = new List<double>();
            bool estado = false;
            while (!backgroundWorker1.CancellationPending)
            {
                pesoHardy = Hardy.pesohardy(ip);
                
                // agrego a la lista todos los pesos del pez para luego obtener el máximo en el ProgressChanged
                ListaPesos.Add(pesoHardy);
                this.lblPesoHardy.Invoke(new MethodInvoker(delegate ()
                {
                    lblPesoHardy.Text = pesoHardy.ToString();
                }));
                
                
                if (pesoHardy < 0.1)
                {
                    estado = false;
                }
                
                if(pesoHardy > 1 && estado == false)
                {
                    if(ListaPesos.Count() > 1)
                    {
                        double ListPesMaxUltimo = ListaPesos.Last();
                        double listPesMaxPenultimo = ListaPesos.ElementAt(ListaPesos.Count - 2);
                        if(listPesMaxPenultimo > ListPesMaxUltimo)
                        {
                            estado = true;
                            backgroundWorker1.ReportProgress(1);    

                        }
                       
                    }
                    

                }


            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pesoHardyMaximo = ListaPesos.Max();
            contador++;
            //lblPesoHardy.Text = "Peso " + pesoHardy;
            lblContadorPez.Text = "Total piezas " + contador;
            DateTime fechaActual = DateTime.Now;
            String query = string.Format($" Insert into  contadora(peso, fecha) values('{ pesoHardyMaximo.ToString().Replace(",", ".") }','{fechaActual}')");
            Console.WriteLine(query);
            // tomar el peso máximo del pez y insertarlo
            int respuesta = conn.Insert(query);
            Console.WriteLine($"espuesta bd {respuesta} ");

            //if (e.ProgressPercentage == 1)
            //{

            //    lblPesoHardy.Text = "Peso Máximo = " + ListaPesos.Max();
            //}
            ListaPesos.Clear();


        }

        public void TrabajoCompletado(object sender, RunWorkerCompletedEventArgs e)
        {
            // Si terminó el trabajo (finalización, cancelación, error), hacer lo siguiente:
            Console.WriteLine();
            Console.WriteLine("Finaliza el Trabajo de prueba");
            // peso máximo de todos los peces que pasaron
            lblPesoHardy.Text = "Peso Máximo = " + pesoHardyMaximo;
            conn.Conectar().Close();

        }
    }
}
