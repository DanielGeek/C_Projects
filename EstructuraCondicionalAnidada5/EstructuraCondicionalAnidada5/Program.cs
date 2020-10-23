using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalAnidada5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPreguntas, totalCorrectas;
            string linea;
            Console.Write("Ingrese la cantidad total de preguntas del examen:");
            linea = Console.ReadLine();
            totalPreguntas = int.Parse(linea);
            Console.Write("Ingrese la cantidad total de preguntas contestadas correctamente:");
            linea = Console.ReadLine();
            totalCorrectas = int.Parse(linea);
            int porcentaje = totalCorrectas * 100 / totalPreguntas;
            if (porcentaje >= 90)
            {
                Console.Write("Nivel máximo");
            }
            else
            {
                if (porcentaje >= 75)
                {
                    Console.Write("Nivel medio");
                }
                else
                {
                    if (porcentaje >= 50)
                    {
                        Console.Write("Nivel regular");
                    }
                    else
                    {
                        Console.Write("Fuera de nivel");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}