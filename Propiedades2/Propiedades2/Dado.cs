using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades2
{
    class Dado
    {
        private int valor;

        public int Valor
        {
            get
            {
                return valor;
            }
            private set
            {
                valor = value;
            }
        }

        private static Random aleatorio;

        public Dado()
        {
            aleatorio = new Random();
        }

        public void Tirar()
        {
            Valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es:" + Valor);
        }
    }
}
