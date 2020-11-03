using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia4
{
    class B : A
    {
        public B(int b) : base(b / 2)
        {
            Console.WriteLine(b);
        }
    }
}
