using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.Write("Ingrese el lado del cuadrado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("El perímetro del cuadrado es:");
            Console.Write(perimetro);
            Console.ReadKey();
        }
    }
}