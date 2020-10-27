using System;

namespace PruebaClase3
{
    class Punto
    {
        private int x, y;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese coordenada x :");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese coordenada y :");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.Write("Se encuentra en el primer cuadrante.");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("Se encuentra en el segundo cuadrante.");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("Se encuentra en el tercer cuadrante.");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.Write("Se encuentra en el cuarto cuadrante.");
                        }
                        else
                        {
                            Console.Write("El punto no está en un cuadrante.");
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Punto punto1 = new Punto();
            punto1.Inicializar();
            punto1.ImprimirCuadrante();
        }
    }
}
