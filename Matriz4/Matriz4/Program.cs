using System;

namespace Matriz4
{
    class Matriz4
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[2, 5];
            Console.WriteLine("Carga de la matriz por columna:");
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.Write("Ingrese componente " + " de la fila " + f + " y la columna " + c + " :");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz4 ma = new Matriz4();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
