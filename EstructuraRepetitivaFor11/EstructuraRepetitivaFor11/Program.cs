using System;

namespace EstructuraRepetitivaFor11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f, x, y, cant1, cant2, cant3, cant4;
            string linea;
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            cant4 = 0;
            Console.Write("Cantidad de puntos:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese coordenada x:");
                linea = Console.ReadLine();
                x = int.Parse(linea);
                Console.Write("Ingrese coordenada y:");
                linea = Console.ReadLine();
                y = int.Parse(linea);
                if (x > 0 && y > 0)
                {
                    cant1++;
                }
                else
                {
                    if (x < 0 && y > 0)
                    {
                        cant2++;
                    }
                    else
                    {
                        if (x < 0 && y < 0)
                        {
                            cant3++;
                        }
                        else
                        {
                            if (x > 0 && y < 0)
                            {
                                cant4++;
                            }
                        }
                    }
                }
            }
            Console.Write("Cantidad de puntos en el primer cuadrante:");
            Console.WriteLine(cant1);
            Console.Write("Cantidad de puntos en el segundo cuadrante:");
            Console.WriteLine(cant2);
            Console.Write("Cantidad de puntos en el tercer cuadrante:");
            Console.WriteLine(cant3);
            Console.Write("Cantidad de puntos en el cuarto cuadrante:");
            Console.WriteLine(cant4);
            Console.ReadKey();
        }
    }
}
