using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            for (f = 1; f <= 100; f++)
            {
                Console.Write(f);
                if (f < 100)
                {
                    Console.Write("-");
                }
                
                
            }
            Console.ReadKey();
        }
    }
}