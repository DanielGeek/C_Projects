using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x += 1;
            }
            Console.ReadKey();
        }
    }
}