using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
    public class Test1000
    {
        public void DoSomething()
        {
            try
            {
                var aClass = ProxyFactory.CreateProxy<IClass1000>();
                bool result = aClass.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
