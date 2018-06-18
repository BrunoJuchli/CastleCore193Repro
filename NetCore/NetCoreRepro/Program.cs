using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NetCoreRepro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int degreeOfParallelism = Environment.ProcessorCount;
            if (args.Length == 1)
            {
                int.TryParse(args[0], out degreeOfParallelism);
            }

            IReadOnlyList<Case> testCases = typeof(Program).Assembly.GetExportedTypes()
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => x.Name.StartsWith("Test"))
                .Select(x => new Case(x))
                .ToList();

            try
            {
                Parallel.ForEach(
                    testCases,
                    new ParallelOptions { MaxDegreeOfParallelism = degreeOfParallelism },
                    x => x.Run());
            }
            catch (AggregateException ex)
            {
                Debugger.Launch();
                Console.Error.WriteLine("not successful");
                foreach (Exception innerException in ex.InnerExceptions)
                {
                    Console.Error.WriteLine();

                    if (innerException is TargetInvocationException tiex)
                    {
                        Console.Error.WriteLine(tiex.InnerException.Message);
                        Console.Error.WriteLine(tiex.InnerException.StackTrace);
                    }
                    else
                    {
                        Console.Error.WriteLine(innerException.Message);
                        Console.Error.WriteLine(innerException.StackTrace);
                    }
                }
            }
        }
    }

    public class Case
    {
        private readonly Type _type;

        public Case(Type type)
        {
            _type = type;
        }

        public void Run()
        {
            var testObject = Activator.CreateInstance(_type);
            _type.GetMethod("DoSomething").Invoke(testObject, new object[0]);
        }
    }
}
