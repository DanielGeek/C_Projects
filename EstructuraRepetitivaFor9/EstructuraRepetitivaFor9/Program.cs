using System;

namespace EstructuraRepetitivaFor9
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, valor;
            string linea;
            Console.Write("Ingrese un valor entre 1 y 10:");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            for (f = valor; f <= valor * 12; f += valor)
            {
                Console.Write(f);
                if (f < valor * 12)
                Console.Write("-");
            }
            Console.ReadKey();
        }
    }
}
