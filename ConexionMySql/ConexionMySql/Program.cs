using System;

namespace ClassMySql
{
    class Program
    {
        static void Main()
        {
            settings_mysql configuracionBD = new settings_mysql();
            Console.WriteLine($"Zona horaria {configuracionBD.MyZone} Host {configuracionBD.Host}  User {configuracionBD.User} Password {configuracionBD.Password} Nombre BD { configuracionBD.NombreBD}");
            ConexionMysql conn = new ConexionMysql();
            
            DateTime fechaActual = DateTime.Now;
            String query = string.Format($" Insert into  contadora(peso, fecha) values('{ 0.25 }','{fechaActual}')");
            int respuesta = conn.Insert(query);
            Console.WriteLine(respuesta);
            // ejecutar al finalizar una query
            conn.Conectar().Close();


        }
    }
}
