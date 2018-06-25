using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Castle.DynamicProxy;

public class Program
{
    public static void Main()
    {
        var proxyGenerator = new ProxyGenerator();
        var typesToProxy = Assembly.GetExecutingAssembly().GetExportedTypes().Where(t => t.Name.StartsWith("Derived"));

        try
        {
            Parallel.ForEach(typesToProxy, typeToProxy =>
            {
                var proxy = (Base)proxyGenerator.CreateClassProxy(typeToProxy);
            });
        }
        catch (Exception ex)
        {
            Console.Beep();
            Console.WriteLine(ex);
            Console.Beep();
            Debugger.Launch();
            throw;
        }
    }
}
