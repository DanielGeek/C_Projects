using System;

namespace EstructuraRepetitivaFor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul3, mul5, valor, f;
            string linea;
            mul3 = 0;
            mul5 = 0;
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese un valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor % 3 == 0)
                {
                    mul3 = mul3 + 1;
                }
                if (valor % 5 == 0)
                {
                    mul5 = mul5 + 1;
                }
            }
            Console.Write("Cantidad de valores ingresados múltiplos de 3:");
            Console.WriteLine(mul3);
            Console.Write("Cantidad de valores ingresados múltiplos de 5:");
            Console.Write(mul5);
            Console.ReadKey();
        }
    }
}