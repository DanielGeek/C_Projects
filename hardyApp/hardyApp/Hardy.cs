using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace hardyApp
{
    class Hardy
    {        
        public static double pesohardy(string ip)
        {
            byte[] bytes = new byte[1024];
            List<String> lista = new List<String>();
            double pesohardydbl = 0;

            try
            {
                // convierte la ip string en ip legible
                IPAddress ipAddress = IPAddress.Parse(ip);
                // uso protocolo tcp por defecto
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1024);
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                sender.Connect(remoteEP);

                byte[] msg = Encoding.ASCII.GetBytes(Environment.NewLine + "0090" + Environment.NewLine);
                int bytesSent = sender.Send(msg);
                int bytesRec = sender.Receive(bytes);
                // pasar de bytes a string
                String lectura = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                try
                {
                    // sustraigo el peso
                    lectura = lectura.Split('=')[1];
                    lectura = lectura.Split('.')[0] + "." + lectura.Split('.')[1].Substring(0, 4);
                }
                catch (Exception e )
                {
                    Console.WriteLine(e.ToString());
                }

                decimal xy = Convert.ToDecimal(lectura);
                double pesohardy = (Double)xy / 100;


              //  double pesohardy = Convert.ToDouble(lectura);
               // pesohardy= pesohardy / 100;
                

                //try
                //{
                //    pesohardydbl = (Convert.ToDouble(pesohardy));
                //}
                //catch (Exception)
                //{

                //}

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return pesohardy;
            }
            catch
            {
                return pesohardydbl;
            }
        }

        // calibración electrónica
        public static string Calibracion_C2(string ip)
        {
            String lectura = "";
            byte[] bytes = new byte[1024];

            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1024);
                Socket sender = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);
                byte[] msg = Encoding.ASCII.GetBytes(Environment.NewLine + "0803=1" + Environment.NewLine);
                int bytesSent = sender.Send(msg);
                int bytesRec = sender.Receive(bytes);
                lectura = Encoding.ASCII.GetString(bytes, 0, bytesRec);
               
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();

                return lectura;
            }
            catch (Exception e)
            {
                return "error" + e;
            }
        }

        public static void setlowhardy(string ip, string pesolow)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1024);
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);
                byte[] msg = Encoding.ASCII.GetBytes(Environment.NewLine + "0202=0" + Environment.NewLine);
                int bytesSent = sender.Send(msg);
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {

            }

        }

        public static string sendlowhardy(string ip)
        {
            byte[] bytes = new byte[1024];
            try
            {

                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1024);

                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);


                sender.Connect(remoteEP);


                byte[] msg = Encoding.ASCII.GetBytes(Environment.NewLine + "0801=1" + Environment.NewLine);

                int bytesSent = sender.Send(msg);

                int bytesRec = sender.Receive(bytes);

                String lectura = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return lectura;


            }
            catch (Exception e)
            {
                return "error";
            }

        }

        public static void setspanhardy(string ip, string pesospan)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1024);
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);
                byte[] msg = Encoding.ASCII.GetBytes(Environment.NewLine + "0201=" + pesospan + Environment.NewLine);
                int bytesSent = sender.Send(msg);
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {

            }
        }


        public static string sendspanhardy(string ip)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1024);
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);
                byte[] msg = Encoding.ASCII.GetBytes(Environment.NewLine + "0800=8" + Environment.NewLine);
                int bytesSent = sender.Send(msg);
                int bytesRec = sender.Receive(bytes);
                String lectura = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return lectura;
            }
            catch (Exception e)
            {
                return "error";
            }

        }

    }
}
