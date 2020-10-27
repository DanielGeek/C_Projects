using System;

namespace PruebaVector12
{
    class PruebaVector12
    {
        private int[] vec;
        private int menor;

        public void Cargar()
        {
            Console.Write("Cuantos elementos desea cargar:");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            vec = new int[n];
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese componente:");
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void MenorElemento()
        {
            menor = vec[0];
            for (int f = 1; f < vec.Length; f++)
            {
                if (vec[f] < menor)
                {
                    menor = vec[f];
                }
            }
            Console.WriteLine("El elemento menor es:" + menor);
        }

        public void RepiteMenor()
        {
            int cant = 0;
            for (int f = 0; f < vec.Length; f++)
            {
                if (vec[f] == menor)
                {
                    cant++;
                }
            }
            if (cant > 1)
            {
                Console.WriteLine("Se repite el menor en el vector.");
            }
            else
            {
                Console.WriteLine("No se repite el menor en el vector.");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PruebaVector12 pv = new PruebaVector12();
            pv.Cargar();
            pv.MenorElemento();
            pv.RepiteMenor();
        }
    }
}
