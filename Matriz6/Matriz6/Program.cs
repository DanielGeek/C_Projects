using System;

namespace Matriz6
{
    class Matriz6
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

        public void ImprimirMayor()
        {
            int mayor = mat[0, 0];
            int filamay = 0;
            int columnamay = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] > mayor)
                    {
                        mayor = mat[f, c];
                        filamay = f;
                        columnamay = c;
                    }
                }
            }
            Console.WriteLine("El elemento mayor es:" + mayor);
            Console.WriteLine("Se encuentra en la fila:" + filamay + " y en la columna: " + columnamay);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Matriz6 ma = new Matriz6();
            ma.Cargar();
            ma.ImprimirMayor();
        }
    }
}
