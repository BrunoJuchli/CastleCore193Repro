using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
    public class Test159
    {
        public void DoSomething()
        {
            try
            {
                var aClass = ProxyFactory.CreateProxy<IClass159>();
                bool result = aClass.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
