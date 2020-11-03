using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia4
{
    class C : B
    {
        public C(int c) : base(c / 2)
        {
            Console.WriteLine(c);
        }
    }
}
