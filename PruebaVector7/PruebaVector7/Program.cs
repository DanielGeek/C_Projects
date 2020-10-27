using System;

namespace PruebaVector7
{
    class PruebaVector7
    {
        private int[] vec;

        public void Cargar()
        {
            vec = new int[10];
            for (int f = 0; f < 10; f++)
            {
                Console.Write("Ingrese elemento:");
                string linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void VerificarOrdenado()
        {
            int orden = 1;
            for (int f = 0; f < 9; f++)
            {
                if (vec[f + 1] < vec[f])
                {
                    orden = 0;
                }
            }
            if (orden == 1)
            {
                Console.WriteLine("Esta ordenado de menor a mayor");
            }
            else
            {
                Console.WriteLine("No esta ordenado de menor a mayor");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector7 pv = new PruebaVector7();
            pv.Cargar();
            pv.VerificarOrdenado();
        }
    }
}
