using System;

namespace EstructuraRepetitivaDoWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant1, cant2, cant3, suma;
            float peso;
            string linea;
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            do
            {
                Console.Write("Ingrese el peso de la pieza (0 pera finalizar):");
                linea = Console.ReadLine();
                peso = float.Parse(linea);
                if (peso > 10.2)
                {
                    cant1++;
                }
                else
                {
                    if (peso >= 9.8)
                    {
                        cant2++;
                    }
                    else
                    {
                        if (peso > 0)
                        {
                            cant3++;
                        }
                    }
                }
            } while (peso != 0);
            suma = cant1 + cant2 + cant3;
            Console.Write("Piezas aptas:");
            Console.WriteLine(cant2);
            Console.Write("Piezas con un peso superior a 10.2:");
            Console.WriteLine(cant1);
            Console.Write("Piezas con un peso inferior a 9.8:");
            Console.WriteLine(cant3);
            Console.Write("Cantidad de piezas procesadas:");
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
