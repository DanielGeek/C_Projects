using System;

namespace PruebaVector6
{
    class PruebaVector6
    {
        private int[] cursoa;
        private int[] cursob;

        public void Cargar()
        {
            cursoa = new int[5];
            cursob = new int[5];
            Console.WriteLine("Carga de notas del curso A");
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese nota:");
                string linea;
                linea = Console.ReadLine();
                cursoa[f] = int.Parse(linea);
            }
            Console.WriteLine("Carga del notas del curso B");
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese nota:");
                string linea;
                linea = Console.ReadLine();
                cursob[f] = int.Parse(linea);
            }
        }

        public void CalcularPromedios()
        {
            int suma1 = 0;
            int suma2 = 0;
            for (int f = 0; f < 5; f++)
            {
                suma1 += cursoa[f];
                suma2 += cursob[f];
            }
            int promedioa = suma1 / 5;
            int promediob = suma2 / 5;
            if (promedioa > promediob)
            {
                Console.WriteLine("El curso A tiene un promedio mayor.");
            }
            else
            {
                Console.WriteLine("El curso B tiene un promedio mayor.");
            }
            Console.ReadKey();
        }

        static void Main()
        {
            PruebaVector6 pv = new PruebaVector6();
            pv.Cargar();
            pv.CalcularPromedios();
        }
    }
}
