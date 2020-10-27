using System;

namespace PruebaConstructor3
{
    class EmpleadoFabrica
    {
        readonly string nombre;
        readonly float sueldo;

        public EmpleadoFabrica()
        {
            Console.Write("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su sueldo:");
            string linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }

        public void PagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.Write("Debe abonar impuestos");
            }
            else
            {
                Console.Write("No paga impuestos");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            EmpleadoFabrica empleado1;
            empleado1 = new EmpleadoFabrica();
            empleado1.PagaImpuestos();
        }
    }
}
