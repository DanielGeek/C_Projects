using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostoCompra
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            float precio, importe;
            string linea;
            Console.Write("Ingrese la cantidad de artículos a llevar:");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            Console.Write("Ingrese el valor unitario del producto:");
            linea = Console.ReadLine();
            precio = float.Parse(linea);
            importe = precio * cantidad;
            Console.Write("El importe total a pagar es:");
            Console.Write(importe);
            Console.ReadKey();
        }
    }
}