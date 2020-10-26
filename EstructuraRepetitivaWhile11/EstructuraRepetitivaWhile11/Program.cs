using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, valor, pares, impares;
            string linea;
            x = 1;
            pares = 0;
            impares = 0;
            Console.Write("Cuantos números ingresará:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.Write("Ingrese el valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea); ;
                if (valor % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
                x += 1;
            }
            Console.Write("Cantidad de pares:");
            Console.WriteLine(pares);
            Console.Write("Cantidad de impares:");
            Console.Write(impares);
            Console.ReadKey();
        }
    }
}