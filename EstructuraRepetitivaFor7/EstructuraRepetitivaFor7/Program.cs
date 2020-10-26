using System;

namespace EstructuraRepetitivaFor7
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, valor, suma;
            string linea;
            suma = 0;
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese un valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (f > 5)
                {
                    suma += valor;
                }
            }
            Console.Write("La suma de los últimos 5 valores es:");
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}
