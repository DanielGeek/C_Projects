using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, conta1, conta2;
            float sueldo, gastos;
            string linea;
            Console.Write("Cuantos empleados tiene la empresa:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            x = 1;
            conta1 = 0;
            conta2 = 0;
            gastos = 0;
            while (x <= n)
            {
                Console.Write("Ingrese el sueldo del empleado:");
                linea = Console.ReadLine();
                sueldo = float.Parse(linea);
                if (sueldo <= 300)
                {
                    conta1 += 1;
                }
                else
                {
                    conta2 += + 1;
                }
                gastos += sueldo;
                x += 1;
            }
            Console.Write("Cantidad de empleados con sueldos entre 100 y 300:");
            Console.WriteLine(conta1);
            Console.Write("Cantidad de empleados con sueldos mayor a 300:");
            Console.WriteLine(conta2);
            Console.Write("Gastos total de la empresa en sueldos:");
            Console.WriteLine(gastos);
            Console.ReadKey();
        }
    }
}
