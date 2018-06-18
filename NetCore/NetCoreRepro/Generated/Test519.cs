using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
    public class Test519
    {
        public void DoSomething()
        {
            try
            {
                var aClass = ProxyFactory.CreateProxy<IClass519>();
                bool result = aClass.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
