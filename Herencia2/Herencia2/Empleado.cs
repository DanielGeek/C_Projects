using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia2
{
    public class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo:" + Sueldo);
        }
    }
}
