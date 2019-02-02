using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace BasicInterception
{
    class CastleInterceptor : Castle.DynamicProxy.IInterceptor
    {
        void IInterceptor.Intercept(IInvocation invocation)
        {
            string test = "";

            invocation.Proceed();
        }
    }
}
