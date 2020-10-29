using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades3
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

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

        public int Antiguedad
        {
            set
            {
                if (value >= 0)
                {
                    antiguedad = value;
                }
                else
                {
                    Console.Write("No se puede asignar aun valor negativo a la antiguedad");
                }
            }
            get
            {
                return antiguedad;
            }
        }
    }
}
