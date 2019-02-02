using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterception
{
    class SomeClass : SomeInterface
    {
        public int SomeFunction(int a, int b)
        {
            return a + b;
        }
    }
}
