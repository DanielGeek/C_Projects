using System;

namespace EstructuraRepetitivaFor10
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, lado1, lado2, lado3, cant1, cant2, cant3, n;
            string linea;
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            Console.Write("Ingrese la cantidad de triángulos:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese lado 1:");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.Write("Ingrese lado 2:");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.Write("Ingrese lado 3:");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Es un triángulo equilatero.");
                    cant1++;
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        Console.WriteLine("Es un triángulo isósceles.");
                        cant2++;
                    }
                    else
                    {
                        cant3++;
                        Console.WriteLine("Es un triángulo escaleno.");
                    }
                }
            }
            Console.Write("Cantidad de triángulos equilateros:");
            Console.WriteLine(cant1);
            Console.Write("Cantidad de triángulos isósceles:");
            Console.WriteLine(cant2);
            Console.Write("Cantidad de triángulos escalenos:");
            Console.WriteLine(cant3);
            if (cant1 < cant2 && cant1 < cant3)
            {
                Console.Write("Hay menor cantidad de triángulos equilateros.");
            }
            else
            {
                if (cant2 < cant3)
                {
                    Console.Write("Hay menor cantidad de triángulos isósceles");
                }
                else
                {
                    Console.Write("Hay menor cantidad de triángulos escalenos");
                }
            }
            Console.ReadKey();
        }
    }
}