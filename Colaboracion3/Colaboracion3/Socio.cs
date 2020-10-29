using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboracion3
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese el nombre del socio:");
            nombre = Console.ReadLine(); ;
            Console.Write("Ingrese la antiguedad:");
            string linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene una antiguedad de " + antiguedad);
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }
    }
}
