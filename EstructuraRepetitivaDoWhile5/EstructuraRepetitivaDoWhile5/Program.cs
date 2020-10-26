using System;

namespace EstructuraRepetitivaDoWhile5
{
    class Program
    {
        static void Main()
        {
            int cuenta;
            float saldo, suma;
            string linea;
            suma = 0;
            do
            {
                Console.Write("Ingrese número de cuenta:");
                linea = Console.ReadLine();
                cuenta = int.Parse(linea);
                if (cuenta >= 0)
                {
                    Console.Write("Ingrese saldo:");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);
                    if (saldo > 0)
                    {
                        Console.WriteLine("Saldo Acreedor.");
                        suma += saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Saldo Deudor.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo Nulo.");
                        }
                    }
                }
            } while (cuenta >= 0);
            Console.Write("Total de saldos Acreedores:");
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}
