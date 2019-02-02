using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterception
{
    public class InterceptedClass
    {
        public virtual string getIntercepted(string a, string b){
            return a + b;
        }
    }
}
