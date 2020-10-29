using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades3
{
    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio1.Nombre = "Juan";
            socio1.Antiguedad = 7;
            socio2 = new Socio();
            socio2.Nombre = "Ana";
            socio2.Antiguedad = 3;
            socio3 = new Socio();
            socio3.Nombre = "Martin";
            socio3.Antiguedad = 25;
        }

        public void MayorAntiguedad()
        {
            if (socio1.Antiguedad > socio2.Antiguedad &&
                socio1.Antiguedad > socio3.Antiguedad)
            {
                Console.WriteLine("Socio com mayor antiguedad:" + socio1.Nombre);
            }
            else
            {
                if (socio2.Antiguedad > socio3.Antiguedad)
                {
                    Console.WriteLine("Socio com mayor antiguedad:" + socio2.Nombre);
                }
                else
                {
                    Console.WriteLine("Socio com mayor antiguedad:" + socio3.Nombre);
                }
            }
        }

    }
}