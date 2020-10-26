using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            float altura, suma, promedio;
            string linea;
            Console.Write("Cuantas personas hay:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            x = 1;
            suma = 0;
            while (x <= n)
            {
                Console.Write("Ingrese la altura:");
                linea = Console.ReadLine();
                altura = float.Parse(linea);
                suma += altura;
                x += 1;
            }
            promedio = suma / n;
            Console.Write("Altura promedio:");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}