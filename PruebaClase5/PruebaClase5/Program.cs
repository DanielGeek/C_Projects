using System;

namespace PruebaClase52
{
    class Empleado
    {
        string nombre;
        float sueldo;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su sueldo:");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }

        public void PagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("No paga impuestos");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Inicializar();
            empleado1.PagaImpuestos();
        }
    }
}

