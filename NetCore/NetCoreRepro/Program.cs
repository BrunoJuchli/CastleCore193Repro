using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using NetCoreRepro;

public class Program
{
    public static void Main()
    {
        try
        {
            Parallel.For(0, 99999, index =>
            {
                Type t = TypeGenerator.CreateClass(index.ToString(CultureInfo.InvariantCulture));
                Activator.CreateInstance(t);
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
