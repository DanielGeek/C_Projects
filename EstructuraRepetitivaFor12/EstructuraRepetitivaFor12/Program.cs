using System;

namespace EstructuraRepetitivaFor12
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, valor, negativos, positivos, mult15, sumapares;
            string linea;
            negativos = 0;
            positivos = 0;
            mult15 = 0;
            sumapares = 0;
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor < 0)
                {
                    negativos++;
                }
                else
                {
                    if (valor > 0)
                    {
                        positivos++;
                    }
                }
                if (valor % 15 == 0)
                {
                    mult15++;
                }
                if (valor % 2 == 0)
                {
                    sumapares += valor;
                }
            }
            Console.Write("Cantidad de valores negativos:");
            Console.WriteLine(negativos);
            Console.Write("Cantidad de valores positivos:");
            Console.WriteLine(positivos);
            Console.Write("Cantidad de valores múltiplos de 15:");
            Console.WriteLine(mult15);
            Console.Write("Suma de los valores pares:");
            Console.WriteLine(sumapares);
            Console.ReadKey();
        }
    }
}
