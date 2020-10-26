using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionesCompuestas6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.Write("Alguno de los números es menor a diez");
            }
            Console.ReadKey();
        }
    }
}
