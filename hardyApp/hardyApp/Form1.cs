using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("k8055d.dll")]
        public static extern int OpenDevice(int CardAddress);

        [DllImport("k8055d.dll")]
        public static extern void CloseDevice();

        [DllImport("k8055d.dll")]
        public static extern int ReadAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void ReadAllAnalog(ref int Data1, ref int Data2);

        [DllImport("k8055d.dll")]
        public static extern void OutputAnalogChannel(int Channel, int Data);

        [DllImport("k8055d.dll")]
        public static extern void OutputAllAnalog(int Data1, int Data2);

        [DllImport("k8055d.dll")]
        public static extern void ClearAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void SetAllAnalog();

        [DllImport("k8055d.dll")]
        public static extern void ClearAllAnalog();

        [DllImport("k8055d.dll")]
        public static extern void SetAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void WriteAllDigital(int Data);

        [DllImport("k8055d.dll")]
        public static extern void ClearDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void ClearAllDigital();

        [DllImport("k8055d.dll")]
        public static extern void SetDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void SetAllDigital();

        [DllImport("k8055d.dll")]
        public static extern bool ReadDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern int ReadAllDigital();

        [DllImport("k8055d.dll")]
        public static extern int ReadCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        public static extern void ResetCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        public static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);

        [DllImport("k8055d.dll")]
        public static extern int Version();

        [DllImport("k8055d.dll")]
        public static extern int SearchDevices();

        [DllImport("k8055d.dll")]
        public static extern int SetCurrentDevice(int lngCardAddress);

        [DllImport("k8055d.dll")]
        public static extern int ReadBackDigitalOut();

        [DllImport("k8055d.dll")]
        public static extern void ReadBackAnalogOut(int[] Buffer);
        public Form1()
        {
            InitializeComponent();

        }

        private void btnPesar_Click(object sender, EventArgs e)
        {

            if (btnPesar.Text == "Iniciar Pesaje")
            {
                btnPesar.Text = "Detener";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                
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
            int CardAddr = 0;
            int h = OpenDevice(CardAddr);
            switch (h)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    bool estadoEntrada2 = ReadDigitalChannel(2);
                    bool estadoEntrada3 = ReadDigitalChannel(3);
                    
                    this.lblEstadoSenor.Invoke(new MethodInvoker(delegate ()
                    {
                        lblEstadoSenor.Text = "Card " + h.ToString() + " connected";
                    }));
                    while (!backgroundWorker1.CancellationPending)
                    {
                        estadoEntrada2 = ReadDigitalChannel(2);
                        estadoEntrada3 = ReadDigitalChannel(3);

                        if (estadoEntrada2)
                        {
                            this.btnSensor2.Invoke(new MethodInvoker(delegate ()
                            {

                                btnSensor2.Enabled = estadoEntrada2;
                            }));


                        } else
                        {
                            this.btnSensor2.Invoke(new MethodInvoker(delegate ()
                            {

                                btnSensor2.Enabled = estadoEntrada2;
                            }));
                        }
                        if (estadoEntrada3)
                        {
                            this.btnSensor3.Invoke(new MethodInvoker(delegate ()

                            {
                                btnSensor3.Enabled = estadoEntrada3;
                            }));

                        } else
                        {
                            this.btnSensor3.Invoke(new MethodInvoker(delegate ()

                            {
                                btnSensor3.Enabled = estadoEntrada3;
                            }));
                        }
                        while (estadoEntrada2 || estadoEntrada3 )
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

                            if (pesoHardy > 1 && estado == false)
                            {
                                if (ListaPesos.Count() > 1)
                                {
                                    double ListPesMaxUltimo = ListaPesos.Last();
                                    double listPesMaxPenultimo = ListaPesos.ElementAt(ListaPesos.Count - 2);
                                    if (listPesMaxPenultimo > ListPesMaxUltimo)
                                    {
                                        estado = true;
                                        backgroundWorker1.ReportProgress(1);

                                    }

                                }
                                

                            }
                            estadoEntrada2 = ReadDigitalChannel(2);
                            estadoEntrada3 = ReadDigitalChannel(3);
                        }
                        

                    }
                    //timer1.Enabled = true;
                    break;
                case -1:
                    lblEstadoSenor.Text = "Card " + CardAddr.ToString() + " not found";
                    break;
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
            lblPesoMaximo.Text = $"Peso máximo {pesoHardyMaximo.ToString()}";
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
            //lblPesoHardy.Text = "Peso Máximo = " + pesoHardyMaximo;
            conn.Conectar().Close();

        }
    }
}
