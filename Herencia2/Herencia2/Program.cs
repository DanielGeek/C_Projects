using System;

namespace Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Edad = 25;
            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Ana";
            empleado1.Edad = 42;
            empleado1.Sueldo = 2524;
            Console.WriteLine("Los datos del empleado son:");
            empleado1.Imprimir();

            Console.ReadKey();
        }
    }
}
