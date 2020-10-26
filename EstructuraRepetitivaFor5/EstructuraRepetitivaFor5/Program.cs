using System;

namespace EstructuraRepetitivaFor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, n, f, valor;
            string linea;
            cantidad = 0;
            Console.Write("Cuantos valores ingresará:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese el valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 1000)
                {
                    cantidad += 1;
                }
            }
            Console.Write("La cantidad de valores ingresados mayores o iguales a 1000 son:");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}
