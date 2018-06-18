using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
    public class Test177
    {
        public void DoSomething()
        {
            try
            {
                var aClass = ProxyFactory.CreateProxy<IClass177>();
                bool result = aClass.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
