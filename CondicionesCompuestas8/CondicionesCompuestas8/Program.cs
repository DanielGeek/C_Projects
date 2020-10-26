using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionesCompuestas8
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            int antiguedad;
            string linea;
            Console.Write("Ingrese sueldo del empleado:");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            Console.Write("Ingrese su antiguedad en años:");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
            if (sueldo < 500 && antiguedad > 10)
            {
                float aumento = sueldo * 0.20f;
                float sueldoTotal = sueldo + aumento;
                Console.Write("Sueldo a pagar:");
                Console.Write(sueldoTotal);
            }
            else
            {
                if (sueldo < 500)
                {
                    float aumento = sueldo * 0.05f;
                    float sueldoTotal = sueldo + aumento;
                    Console.Write("Sueldo a pagar:");
                    Console.Write(sueldoTotal);
                }
                else
                {
                    Console.Write("Sueldo a pagar:");
                    Console.Write(sueldo);
                }
            }
            Console.ReadKey();
        }
    }
}