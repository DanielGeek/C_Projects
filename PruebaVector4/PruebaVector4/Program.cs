using System;

namespace PruebaVector4
{
    class PruebaVector4
    {
        private int[] vec;

        public void Cargar()
        {
            vec = new int[8];
            for (int f = 0; f < 8; f++)
            {
                Console.Write("Ingrese elemento:");
                string linea;
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void AcumularElementos()
        {
            int suma = 0;
            for (int f = 0; f < 8; f++)
            {
                suma += vec[f];
            }
            Console.WriteLine("La suma de los 8 elementos es:" + suma);
        }

        public void AcumularMayores36()
        {
            int suma = 0;
            for (int f = 0; f < 8; f++)
            {
                if (vec[f] > 36)
                {
                    suma += vec[f];
                }
            }
            Console.WriteLine("La suma de los elementos mayores a 36 es:" + suma);
        }

        public void CantidadMayores50()
        {
            int cant = 0;
            for (int f = 0; f < 8; f++)
            {
                if (vec[f] > 50)
                {
                    cant++;
                }
            }
            Console.WriteLine("La cantidad de valores mayores a 50 es:" + cant);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector4 pv = new PruebaVector4();
            pv.Cargar();
            pv.AcumularElementos();
            pv.AcumularMayores36();
            pv.CantidadMayores50();
        }
    }
}
