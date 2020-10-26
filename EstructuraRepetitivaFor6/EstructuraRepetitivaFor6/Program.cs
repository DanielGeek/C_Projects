using System;

namespace EstructuraRepetitivaFor6
{
    class Program
    {
        static void Main(string[] args)
        {
            int basetri, altura, superficie, cantidad, f, n;
            string linea;
            cantidad = 0;
            Console.Write("Cuantos triángulos procesará:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese el valor de la base:");
                linea = Console.ReadLine();

                basetri = int.Parse(linea);
                Console.Write("Ingrese el valor de la altura:");
                linea = Console.ReadLine();
                altura = int.Parse(linea);
                superficie = basetri * altura / 2;
                Console.Write("La superficie es:");
                Console.WriteLine(superficie);
                if (superficie > 12)
                {
                    cantidad += 1;
                }
            }
            Console.Write("La cantidad de triángulos con superficie superior a 12 son:");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}
