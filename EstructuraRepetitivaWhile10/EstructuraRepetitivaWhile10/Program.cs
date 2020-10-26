using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile10
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, x, suma1, suma2;
            string linea;
            x = 1;
            suma1 = 0;
            suma2 = 0;
            Console.WriteLine("Primer lista");
            while (x <= 15)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma1 += valor;
                x += 1;
            }
            Console.WriteLine("Segunda lista");
            x = 1;
            while (x <= 15)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma2 += valor;
                x += 1;
            }
            if (suma1 > suma2)
            {
                Console.Write("Lista 1 mayor.");
            }
            else
            {
                if (suma2 > suma1)
                {
                    Console.Write("Lista2 mayor.");
                }
                else
                {
                    Console.Write("Listas iguales.");
                }
            }
            Console.ReadKey();
        }
    }
}