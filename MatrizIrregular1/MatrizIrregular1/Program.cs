using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizIrregular1
{
    class MatrizIrregular1
    {
        private int[][] mat;

        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);
            mat = new int[filas][];
            for (int f = 0; f < mat.Length; f++)
            {
                Console.Write("Cuantas elementos tiene la fila " + f + ":");
                linea = Console.ReadLine();
                int elementos = int.Parse(linea);
                mat[f] = new int[elementos];
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
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
            Console.ReadLine();
        }

        static void Main()
        {
            MatrizIrregular1 ma = new MatrizIrregular1();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
