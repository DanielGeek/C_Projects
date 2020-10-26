using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, f, valor, promedio;
            string linea;
            suma = 0;
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma += valor;
            }
            Console.Write("La suma es:");
            Console.WriteLine(suma);
            promedio = suma / 10;
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}