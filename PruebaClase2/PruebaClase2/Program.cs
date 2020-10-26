using System;

namespace PruebaClase2
{
    class Triangulo
    {
        private int lado1, lado2, lado3;

        public void Inicializar()
        {
            string linea;
            Console.Write("Medida lado 1:");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);
            Console.Write("Medida lado 2:");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);
            Console.Write("Medida lado 3:");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);
        }

        public void LadoMayor()
        {
            Console.Write("Lado mayor:");
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine(lado1);
            }
            else
            {
                if (lado2 > lado3)
                {
                    Console.WriteLine(lado2);
                }
                else
                {
                    Console.WriteLine(lado3);
                }
            }
        }

        public void EsEquilatero()
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.Write("Es un triángulo equilátero");
            }
            else
            {
                Console.Write("No es un triángulo equilátero");
            }
        }

        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.Inicializar();
            triangulo1.LadoMayor();
            triangulo1.EsEquilatero();
            Console.ReadKey();
        }
    }
}
