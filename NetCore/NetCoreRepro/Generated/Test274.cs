using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
    public class Test274
    {
        public void DoSomething()
        {
            try
            {
                var aClass = ProxyFactory.CreateProxy<IClass274>();
                bool result = aClass.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
