using System;

namespace PruebaVector3
{
    class PruebaVector3
    {
        private float[] turnoMan;
        private float[] turnoTar;

        public void Cargar()
        {
            string linea;
            turnoMan = new float[4];
            turnoTar = new float[4];
            Console.WriteLine("Sueldos de empleados del turno de la mañana.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                turnoMan[f] = float.Parse(linea);
            }
            Console.WriteLine("Sueldos de empleados del turno de la tarde.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                turnoTar[f] = float.Parse(linea);
            }
        }

        public void CalcularGastos()
        {
            float man = 0;
            float tar = 0;
            for (int f = 0; f < 4; f++)
            {
                man += turnoMan[f];
                tar += turnoTar[f];
            }
            Console.WriteLine("Total de gastos del turno de la mañana:" + man);
            Console.WriteLine("Total de gastos del turno de la tarde:" + tar);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            PruebaVector3 pv = new PruebaVector3();
            pv.Cargar();
            pv.CalcularGastos();
        }
    }
}
