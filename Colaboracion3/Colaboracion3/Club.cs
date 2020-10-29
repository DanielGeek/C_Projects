using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboracion3
{
    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void MayorAntiguedad()
        {
            Console.Write("Socio con mayor antiguedad:");
            if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }
            }

        }
    }
}
