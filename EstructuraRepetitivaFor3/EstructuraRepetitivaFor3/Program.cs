using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aprobados, reprobados, f, nota;
            string linea;
            aprobados = 0;
            reprobados = 0;
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese la nota:");
                linea = Console.ReadLine();
                nota = int.Parse(linea);
                if (nota >= 7)
                {
                    aprobados += 1;
                }
                else
                {
                    reprobados += 1;
                }
            }
            Console.Write("Cantidad de aprobados:");
            Console.WriteLine(aprobados);
            Console.Write("Cantidad de reprobados:");
            Console.Write(reprobados);
            Console.ReadKey();
        }
    }
}