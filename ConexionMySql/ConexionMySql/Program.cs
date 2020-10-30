using System;

namespace ClassMySql
{
    class Program
    {
        static void Main()
        {
            
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
