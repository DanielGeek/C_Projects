using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia1
{
    public class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }
}
