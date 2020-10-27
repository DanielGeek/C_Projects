using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConstructor1
{
    class Operarios
    {
        private readonly int[] sueldos;

        public Operarios()
        {
            sueldos = new int[5];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese el sueldo:");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main()
        {
            Operarios op = new Operarios();
            op.Imprimir();
        }
    }
}