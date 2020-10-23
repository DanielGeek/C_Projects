using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalAnidada3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.Write("Ingrese un valor:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num == 0)
            {
                Console.Write("Se ingresó el cero");
            }
            else
            {
                if (num > 0)
                {
                    Console.Write("Se ingresó un valor positivo");
                }
                else
                {
                    Console.Write("Se ingresó un valor negativo");
                }
            }
            Console.ReadKey();
        }
    }
}