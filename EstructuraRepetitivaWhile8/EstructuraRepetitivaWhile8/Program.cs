using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, termino;
            x = 1;
            termino = 11;
            while (x <= 25)
            {
                Console.Write(termino);
                
                x += 1;
                if(x <= 25)
                {
                    Console.Write(" - ");
                }
                termino += 11;
            }
            Console.ReadKey();
        }
    }
}