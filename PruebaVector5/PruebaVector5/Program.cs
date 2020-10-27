using System;

namespace PruebaVector5
{
    class PruebaVector5
    {
        private int[] vec1;
        private int[] vec2;
        private int[] vecSuma;

        public void Cargar()
        {
            vec1 = new int[4];
            vec2 = new int[4];
            Console.WriteLine("Carga del primer vector.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese elemento:");
                string linea;
                linea = Console.ReadLine();
                vec1[f] = int.Parse(linea);
            }
            Console.WriteLine("Carga del segundo vector.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese elemento:");
                string linea;
                linea = Console.ReadLine();
                vec2[f] = int.Parse(linea);
            }
        }

        public void SumarizarVectores()
        {
            vecSuma = new int[4];
            for (int f = 0; f < 4; f++)
            {
                vecSuma[f] = vec1[f] + vec2[f];
            }
            Console.WriteLine("Vector resultante.");
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine(vecSuma[f]);
            }
            Console.ReadKey();
        }

        static void Main()
        {
            PruebaVector5 pv = new PruebaVector5();
            pv.Cargar();
            pv.SumarizarVectores();
        }
    }
}
