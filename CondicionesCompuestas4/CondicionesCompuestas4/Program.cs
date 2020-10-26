using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionesCompuestas4
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
            if (num1 == num2 && num1 == num3)
            {
                int suma = num1 + num2;
                Console.Write("La suma del primero y segundo:");
                Console.WriteLine(suma);
                int producto = suma * num3;
                Console.Write("La suma del primero y segundo multiplicado por el tercero:");
                Console.Write(producto);
            }
            Console.ReadKey();
        }
    }
}