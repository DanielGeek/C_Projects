using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMySql
{
    class ConexionMysql
    {
        private settings_mysql configuracionBD = new settings_mysql();
        private TimeZoneInfo Zona;
        private String Host;
        private String User;
        private String Password;
        private String nombreBD;
        public MySqlConnection enlace;
        private int retorno;
        private String EstadoConn;
        public ConexionMysql()
        {
            Zona     = configuracionBD.MyZone;
            Host     = configuracionBD.Host;
            User     = configuracionBD.User;
            Password = configuracionBD.Password;
            nombreBD = configuracionBD.NombreBD;
        }


        public MySqlConnection Conectar()
        {
            String CadenaConexion = $"server={Host}; Uid={User}; pwd={Password}; database={nombreBD};";
            try
            {
                enlace = new MySqlConnection(CadenaConexion);
                
                enlace.Open();
                
                return enlace;
                
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        return new MySqlConnection();
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        return new MySqlConnection();
                    default:
                        Console.WriteLine("No existe la bd");
                        return new MySqlConnection();
                }
                
            }  
            
        }

        public int Insert(String query)
        {
            
            this.EstadoConn = this.Conectar().State.ToString();
            if (EstadoConn == "Open")
            {
                Console.WriteLine("Conectado");
                Console.WriteLine($"Estado {EstadoConn}");
                try
                {
                    
                    MySqlCommand comando = new MySqlCommand(query, this.Conectar());
                    comando.ExecuteNonQuery();
                    this.retorno = (int)comando.LastInsertedId;
                    return this.retorno;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return this.retorno;
                }
            }
            else
            {
                return this.retorno;
            }


            

        }
    }
}
