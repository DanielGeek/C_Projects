using System;

namespace PruebaVector15
{
    class PruebaVector15
    {
        private int[] vec;

        public void Cargar()
        {
            Console.Write("Cuantos elementos tendrá el vector:");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vec = new int[cant];
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese elemento:");
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void Ordenar()
        {
            for (int k = 0; k < vec.Length; k++)
            {
                for (int f = 0; f < vec.Length - 1 - k; f++)
                {
                    if (vec[f] > vec[f + 1])
                    {
                        int aux;
                        aux = vec[f];
                        vec[f] = vec[f + 1];
                        vec[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados de menor a mayor.");
            for (int f = 0; f < vec.Length; f++)
            {
                Console.WriteLine(vec[f]);
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            PruebaVector15 pv = new PruebaVector15();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();
        }
    }
}
