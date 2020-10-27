using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz10
{
    class Matriz10
    {
        private string[] paises;
        private int[,] tempmen;
        private int[] temptri;

        public void Cargar()
        {
            paises = new String[4];
            tempmen = new int[4, 3];
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el nombre del país:");
                paises[f] = Console.ReadLine();
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    Console.Write("Ingrese temperatura mensual:");
                    string linea = Console.ReadLine();
                    tempmen[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirTempMensuales()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Pais:" + paises[f] + ":");
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    Console.Write(tempmen[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void CalcularTemperaturaTri()
        {
            temptri = new int[4];
            for (int f = 0; f < tempmen.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    suma += tempmen[f, c];
                }
                temptri[f] = suma / 3;
            }
        }

        public void ImprimirTempTrimestrales()
        {
            Console.WriteLine("Temperaturas trimestrales.");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f] + " " + temptri[f]);
            }
        }

        public void PaisMayorTemperaturaTri()
        {
            int may = temptri[0];
            string nom = paises[0];
            for (int f = 0; f < paises.Length; f++)
            {
                if (temptri[f] > may)
                {
                    may = temptri[f];
                    nom = paises[f];
                }
            }
            Console.WriteLine("Pais con temperatura trimestral mayor es " + nom + " que tiene una temperatura de " + may);
        }

        static void Main()
        {
            Matriz10 ma = new Matriz10();
            ma.Cargar();
            ma.ImprimirTempMensuales();
            ma.CalcularTemperaturaTri();
            ma.ImprimirTempTrimestrales();
            ma.PaisMayorTemperaturaTri();
            Console.ReadKey();
        }
    }
}