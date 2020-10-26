using System;

namespace CadenaDeCaracteres1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre1, nombre2;
            int edad1, edad2;
            String linea;
            Console.Write("Ingrese el nombre:");
            nombre1 = Console.ReadLine();
            Console.Write("Ingrese edad:");
            linea = Console.ReadLine();
            edad1 = int.Parse(linea);
            Console.Write("Ingrese el nombre:");
            nombre2 = Console.ReadLine();
            Console.Write("Ingrese edad:");
            linea = Console.ReadLine();
            edad2 = int.Parse(linea);
            Console.Write("La persona de mayor edad es:");
            if (edad1 > edad2)
            {
                Console.Write(nombre1);
            }
            else
            {
                if(edad1 == edad2)
                {
                    Console.Write(nombre1 + " y " + nombre2);
                }
                else
                {
                    Console.Write(nombre2);

                }
            }
            Console.ReadKey();
        }
    }
}