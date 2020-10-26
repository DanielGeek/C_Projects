using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, nota, conta1, conta2;
            string linea;
            x = 1;
            conta1 = 0;
            conta2 = 0;
            while (x <= 10)
            {
                Console.Write("Ingrese nota:");
                linea = Console.ReadLine();
                nota = int.Parse(linea);
                if (nota >= 7)
                {
                    conta1 += 1;
                }
                else
                {
                    conta2 += 1;
                }
                x += 1;
            }
            Console.Write("Cantidad de alumnos con notas mayores o iguales a 7:");
            Console.WriteLine(conta1);
            Console.Write("Cantidad de alumons con notas menores a 7:");
            Console.Write(conta2);
            Console.ReadKey();
        }
    }
}