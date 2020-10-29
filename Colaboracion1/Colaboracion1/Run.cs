using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboracion1
{
    class Run
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
