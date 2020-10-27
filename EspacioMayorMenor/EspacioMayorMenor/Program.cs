using System;

namespace EspacioMayorMenor
{
    class MayorMenor
    {

        public void CargarValores()
        {
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            int valor1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            int valor2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            int valor3 = int.Parse(linea);
            int mayor, menor;
            mayor = CalcularMayor(valor1, valor2, valor3);
            menor = CalcularMenor(valor1, valor2, valor3);
            Console.WriteLine("El valor mayor de los tres es:" + mayor);
            Console.WriteLine("El valor menor de los tres es:" + menor);
        }

        public int CalcularMayor(int v1, int v2, int v3)
        {
            int m;
            if (v1 > v2 && v1 > v3)
            {
                m = v1;
            }
            else
            {
                if (v2 > v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        public int CalcularMenor(int v1, int v2, int v3)
        {
            int m;
            if (v1 < v2 && v1 < v3)
            {
                m = v1;
            }
            else
            {
                if (v2 < v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        static void Main()
        {
            MayorMenor mm = new MayorMenor();
            mm.CargarValores();
            Console.ReadKey();
        }
    }
}