using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizIrregular3
{
    class MatrizIrregular3
    {
        private string[] nombres;
        private int[][] dias;

        public void Cargar()
        {
            nombres = new string[3];
            dias = new int[3][];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                nombres[f] = Console.ReadLine();
                Console.Write("Cuantas días faltó el empleado:");
                string linea = Console.ReadLine();
                int faltas = int.Parse(linea);
                dias[f] = new int[faltas];
                for (int c = 0; c < dias[f].Length; c++)
                {
                    Console.Write("Ingrese nro de día:");
                    linea = Console.ReadLine();
                    dias[f][c] = int.Parse(linea);
                }
            }
        }

        public void Inasistencias()
        {
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.WriteLine(nombres[f] + " faltó " + dias[f].Length + " días");
            }
        }

        public void EmpleadoMenosFaltas()
        {
            int faltas = dias[0].Length;
            string nom = nombres[0];
            for (int f = 1; f < dias.Length; f++)
            {
                if (dias[f].Length < faltas)
                {
                    faltas = dias[f].Length;
                    nom = nombres[f];
                }
            }
            Console.WriteLine("El empleado que faltó menos es " + nom + " con " + faltas + " faltas.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MatrizIrregular3 ma = new MatrizIrregular3();
            ma.Cargar();
            ma.Inasistencias();
            ma.EmpleadoMenosFaltas();
        }
    }
}
