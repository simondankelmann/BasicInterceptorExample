using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using StructureMap;

namespace BasicInterception
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxyGenerator = new ProxyGenerator();

            var container = new Container(_ =>
            {
                // Intercepted Interface
                _.For<SomeInterface>().DecorateAllWith(i => proxyGenerator.CreateInterfaceProxyWithTargetInterface(i, new CastleInterceptor())).Use<SomeClass>();
                // Intercepted Class
                _.For<InterceptedClass>().DecorateAllWith(i => proxyGenerator.CreateClassProxyWithTarget<InterceptedClass>(i, new CastleInterceptor())).Use<InterceptedClass>();
                
            });


            /* Intercepted Interface */
            /*
            var instance = container.GetInstance<SomeInterface>();
            int result = instance.SomeFunction(5,15);
            Console.WriteLine("Result is: " + result.ToString());
            */

            /* Intercepted Class */
            var instance = container.GetInstance<InterceptedClass>();
            string result = instance.getIntercepted("First String","Second String");
            Console.WriteLine("Result is: " + result);

            Console.WriteLine("");
            Console.WriteLine("Press enter to exit");
            // Dont close yet
            Console.ReadLine();
        }
    }
}
