using System;

namespace PruebaVector9
{
    class PruebaVector9
    {
        private int[] elementos;
        public void Cargar()
        {
            Console.Write("Ingrese tamaño del Vector:");
            string linea;
            linea = Console.ReadLine();
            int tamaño = int.Parse(linea);
            elementos = new int[tamaño];
            for (int f = 0; f < elementos.Length; f++)
            {
                Console.Write("Ingrese valor a sumar:");
                linea = Console.ReadLine();
                elementos[f] = int.Parse(linea);
            }
        }

        public void Sumar()
        {
            int sumaTotal = 0;
            for (int f = 0; f < elementos.Length; f++)
            {
                sumaTotal += elementos[f];
                Console.WriteLine(elementos[f]);
            }
            Console.WriteLine("Suma total " + sumaTotal);
            Console.ReadKey();
        }

        static void Main()
        {
            PruebaVector9 pv = new PruebaVector9();
            pv.Cargar();
            pv.Sumar();
        }
    }
}
