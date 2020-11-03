using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseParcial1
{
    partial class Rectangulo
    {
        public int RetornarSuperficie()
        {
            int sup = Lado1 * Lado2;
            return sup;
        }

        public int RetornarPerimetro()
        {
            int per = Lado1 * 2 + Lado2 * 2;
            return per;
        }
    }
}
