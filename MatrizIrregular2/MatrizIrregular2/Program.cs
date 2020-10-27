using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizIrregular2
{
    class MatrizIrregular2
    {
        private int[][] mat;

        public void Cargar()
        {
            mat = new int[5][];
            for (int f = 0; f < mat.Length; f++)
            {
                mat[f] = new int[f + 1];
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write("Ingrese componente:");
                    string linea = Console.ReadLine();
                    mat[f][c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.Length; f++)
            {
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write(mat[f][c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MatrizIrregular2 ma = new MatrizIrregular2();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
