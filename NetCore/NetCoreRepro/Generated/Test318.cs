using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
    public class Test318
    {
        public void DoSomething()
        {
            try
            {
                var aClass = ProxyFactory.CreateProxy<IClass318>();
                bool result = aClass.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
