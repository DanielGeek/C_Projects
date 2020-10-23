using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalCompuesta3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.Write("Ingrese un valor entero de 1 o 2 dígitos:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num < 10)
            {
                Console.Write("Tiene un dígito");
            }
            else
            {
                Console.Write("Tiene dos dígitos");
            }
            Console.ReadKey();
        }
    }
}