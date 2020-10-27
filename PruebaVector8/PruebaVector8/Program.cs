using System;

namespace PruebaVector8
{
    class PruebaVector8
    {
        private int[] sueldos;

        public void Cargar()
        {
            Console.Write("Cuantos sueldos cargará:");
            string linea;
            linea = Console.ReadLine();
            int cant = int.Parse(linea);
            sueldos = new int[cant];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector8 pv = new PruebaVector8();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
