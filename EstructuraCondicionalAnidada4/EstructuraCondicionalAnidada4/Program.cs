using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalAnidada4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.Write("Ingrese un valor de hasta tres dígitos positivo:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num < 10)
            {
                Console.Write("Tiene un dígito");
            }
            else
            {
                if (num < 100)
                {
                    Console.Write("Tiene dos dígitos");
                }
                else
                {
                    if (num < 1000)
                    {
                        Console.Write("Tiene tres dígitos");
                    }
                    else
                    {
                        Console.Write("Error en la entrada de datos.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}