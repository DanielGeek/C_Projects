using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile9
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult8;
            mult8 = 8;
            while (mult8 <= 500)
            {
                Console.Write(mult8);
                mult8 += 8;
                if (mult8 <= 500)
                {
                    Console.Write(" - ");
                }
            }
            Console.ReadKey();
        }
    }
}