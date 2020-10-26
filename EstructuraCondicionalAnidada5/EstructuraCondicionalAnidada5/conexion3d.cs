using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contadora3D.Clases
{
    class Conexion3d
    {
        public List<string>  get_ClientesDB()
        {
            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = "SELECT cliente_name FROM clientes WHERE cliente_status = 'activo' ORDER BY cliente_id ASC;";

            leer = cmd.ExecuteReader();
            List<string> clien= new List<string>();
            if (leer.HasRows)
            {
                while (leer.Read())
                {                   
                   // Console.WriteLine(leer.GetValue(0).ToString());
                    clien.Add(leer.GetValue(0).ToString());
                }
            }

            cnn.Close();
            return clien;
        }
        public void get_faenasDB()
        {

            //Revisar si el DB esta abierto
           // openDB();
            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = "SELECT* FROM faena WHERE estatus = 0 ORDER BY id ASC;";

            leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {

                while (leer.Read())
                {
                    Clases.Faena objfaena = new Clases.Faena();
                    Console.WriteLine(leer.GetValue(0).ToString() + leer.GetValue(1).ToString() + leer.GetValue(2).ToString() + leer.GetValue(3).ToString());
                    objfaena.Codigo_F5 = leer.GetValue(5).ToString();
                    objfaena.Cantidad_prog = Convert.ToInt32(leer.GetValue(7));
                    objfaena.Conteo_Actual = Convert.ToInt32(leer.GetValue(9));
                    objfaena.Avance = 0;
                    objfaena.Cliente = leer.GetValue(2).ToString();
                    objfaena.Especie = leer.GetValue(3).ToString();
                    objfaena.Turno = leer.GetValue(4).ToString();
                    objfaena.Fecha = leer.GetValue(1).ToString();
                    objfaena.ActualF5 = Convert.ToBoolean(leer.GetValue(10));
                    objfaena.Estatus = Convert.ToBoolean(leer.GetValue(8));
                    objfaena.id = Convert.ToInt32(leer.GetValue(0));
                    Form1.ListaFaena.Add(objfaena);
                }
            }

            cnn.Close();
        }

        public void update_act_faena(int id)
        {
            string query = "UPDATE faena SET ActualF5=1 WHERE id=" + id + ";";

            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = query;
            int filas = cmd.ExecuteNonQuery();
            if (filas >= 1)
            {
                // status = true;
            }
            cnn.Close();

        }

        public void Update_conteo(int cont)
        {
            string query = "UPDATE faena SET conteo=" + cont + " WHERE ActualF5=1;";

            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = query;
            int filas = cmd.ExecuteNonQuery();
            if (filas >= 1)
            {
                // status = true;
            }
            cnn.Close();
        }
        public void completed(int id)
        {
            string query = "UPDATE faena SET ActualF5=0,estatus=1 WHERE id=" + id + ";";
            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = query;
            int filas = cmd.ExecuteNonQuery();
            if (filas >= 1)
            {
                // status = true;
            }
            cnn.Close();
        }
    


        public void openDB()
        {
            Process[] localByName = Process.GetProcessesByName("mysqld");
            int f = localByName.Count();
            if (f == 0)
            {
                Process.Start(@"C:\xampp\xampp_start.exe");

            }
        }


        public Int32[] get_first_id()
        {
            openDB();
            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = "SELECT id,ActualF5,conteo FROM faena WHERE Estatus = 0 ORDER BY id asc LIMIT 1;";

            leer = cmd.ExecuteReader();
            int id_faena = -1;
            int act_f5 = 0;
            int ct_actual = 0;
            int[] val_1 = new int[3];
            if (leer.HasRows)
            {

                while (leer.Read())
                {
                    id_faena = Convert.ToInt32(leer.GetValue(0));
                    act_f5 = Convert.ToInt32(leer.GetValue(1));
                    ct_actual = Convert.ToInt32(leer.GetValue(2));
                    val_1 = new int[] { id_faena, act_f5, ct_actual };
                }
            }
            cnn.Close();
            return val_1;

        }
        public void Set_faenasDB(string F5, int CantidadProg, int ConteoActual, string cliente, string especie, string turno, string fecha, int ActualF5, int Estatus, string tipo)
        {
            //string query = "INSERT INTO faenas(CodigoF5,CantidadProg,ConteoActual,Avance,Cliente,Especie,Turno,Fecha,ActualF5,Estatus) VALUES('GHU15',1003,0,0,'AQUA','trucha','noche',now(),1,0);";
            openDB();
            string query = "INSERT INTO faena(Codigof5,Pieza_programada,conteo,cliente,especie,turno,fecha,ActualF5,estatus,tipo) VALUES('" + @F5 + "'," + @CantidadProg + "," + @ConteoActual  + ",'" + @cliente + "','" + @especie + "','" + @turno + "','" + @fecha + "'," + @ActualF5 + "," + @Estatus + ",'" + @tipo + "');";

            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = query;
            int filas = cmd.ExecuteNonQuery();
            if (filas >= 1)
            {
                // status = true;
            }
            cnn.Close();


        }
        public void Edit_faenasDB(string F5, string Tipo, int CantidadProg, int id)
        {
           // (codigoF5, Tipo, CantidadProg)         
           // openDB();
            //string query = "INSERT INTO faena(Codigof5,Pieza_programada,conteo,cliente,especie,turno,fecha,ActualF5,estatus) VALUES('" + @F5 + "'," + @CantidadProg + "," + @ConteoActual + ",'" + @cliente + "','" + @especie + "','" + @turno + "','" + @fecha + "'," + @ActualF5 + "," + @Estatus + ");";
            string query = "UPDATE faena SET codigof5= '"+ F5 + "', tipo= '"+ Tipo +"' , pieza_programada= "+ CantidadProg + " WHERE id=" + id + ";";
            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = query;
            int filas = cmd.ExecuteNonQuery();
            if (filas >= 1)
            {
                // status = true;
            }
            cnn.Close();

        }
        public Int32 get_last_ID()
        {
            MySqlConnection cnn = new MySqlConnection(ReadConnection());
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader leer;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.CommandText = "SELECT @@identity AS id;";
            leer = cmd.ExecuteReader();
            int val = 0;
            if (leer.HasRows)
            {
                //while (leer.Read())
                //{
                //}
                val= Convert.ToInt32(leer.GetValue(0));
            }
            else
            {
                val= -1;
            }
            cnn.Close();
            return val;

        }



        public static string ReadConnection()
        {
            // return "datasource=localhost ;username=root;password=;database=telemetria;";
            // return "datasource=192.168.0.43 ;username=root;password=;database=db_contadora3d;"
          //  return "datasource=127.0.0.1 ;username=root;password=;database=db_contadora3d;";
             return "datasource=127.0.0.1 ;username=root;password=;database=gradder;";
        }
    }

}
