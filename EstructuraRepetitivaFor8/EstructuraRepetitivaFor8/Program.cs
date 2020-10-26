using System;

namespace EstructuraRepetitivaFor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            for (f = 5; f <= 50; f += 5)
            {
                Console.Write(f);
                if(f < 50)
                    Console.Write("-");
            }
            Console.ReadKey();
        }
    }
}
