using System;

namespace PruebaVector17
{
    class PruebaVector17
    {
        private string[] paises;
        private int[] habitantes;

        public void Cargar()
        {
            paises = new string[5];
            habitantes = new int[5];
            Console.WriteLine("Carga de paises y habitantes");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingese el nombre del pais:");
                paises[f] = Console.ReadLine();
                Console.Write("Ingrese la cantidad de habitantes:");
                string linea;
                linea = Console.ReadLine();
                habitantes[f] = int.Parse(linea);
            }
        }

        public void OrdenarPorNombres()
        {
            for (int k = 0; k < paises.Length; k++)
            {
                for (int f = 0; f < paises.Length - 1 - k; f++)
                {
                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        string auxpais;
                        auxpais = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxpais;
                        int auxhabitante;
                        auxhabitante = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = auxhabitante;
                    }
                }
            }
        }

        public void OrdenarPorHabitantes()
        {
            for (int k = 0; k < paises.Length; k++)
            {
                for (int f = 0; f < paises.Length - 1 - k; f++)
                {
                    if (habitantes[f] < habitantes[f + 1])
                    {
                        string auxpais;
                        auxpais = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxpais;
                        int auxhabitante;
                        auxhabitante = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = auxhabitante;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f] + " - " + habitantes[f]);
            }
        }

        static void Main(string[] args)
        {
            PruebaVector17 pv = new PruebaVector17();
            pv.Cargar();
            pv.OrdenarPorNombres();
            Console.WriteLine("Ordenados alfabéticamente");
            pv.Imprimir();
            pv.OrdenarPorHabitantes();
            Console.WriteLine("Ordenados por cantidad de habitnates");
            pv.Imprimir();
            Console.ReadKey();
        }
    }
}
