using System;

namespace Propiedades1
{
    class Program
    {
        static void Main()
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}
