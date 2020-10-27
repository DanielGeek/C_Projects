using System;

namespace Matriz8
{
    class Matriz8
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirVertices()
        {
            Console.WriteLine("Vértice superior izquierdo:");
            Console.WriteLine(mat[0, 0]);
            Console.WriteLine("Vértice superior derecho:");
            Console.WriteLine(mat[0, mat.GetLength(1) - 1]);
            Console.WriteLine("Vértice inferior izquierdo:");
            Console.WriteLine(mat[mat.GetLength(0) - 1, 0]);
            Console.WriteLine("Vértice inferior derecho:");
            Console.WriteLine(mat[mat.GetLength(0) - 1, mat.GetLength(1) - 1]);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz8 ma = new Matriz8();
            ma.Cargar();
            ma.ImprimirVertices();
        }
    }
}