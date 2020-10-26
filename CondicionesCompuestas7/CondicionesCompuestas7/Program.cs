using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionesCompuestas7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string linea;
            Console.Write("Ingrese coordenada x:");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese coordenada y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
            if (x > 0 && y > 0)
            {
                Console.Write("Se encuentra en el primer cuadrante");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("Se encuentra en el segundo cuadrante");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("Se encuentra en el tercer cuadrante");
                    }
                    else
                    {
                        Console.Write("Se encuentra en el cuarto cuadrante");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}