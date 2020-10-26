using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionCompuesta2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            string linea;
            Console.Write("Ingrese nro de día:");
            linea = Console.ReadLine();
            dia = int.Parse(linea); ;
            Console.Write("Ingrese nro de mes:");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            Console.Write("Ingrese nro de año:");
            linea = Console.ReadLine();
            año = int.Parse(linea);
            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.Write("Corresponde al primer trimestre");
            }
            Console.ReadLine();
        }
    }
}