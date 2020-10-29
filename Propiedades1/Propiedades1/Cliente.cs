using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades1
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Monto
        {
            set
            {
                monto = value;
            }
            get
            {
                return monto;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine(Nombre + " tiene depositado la suma de " + Monto);
        }
    }
}
