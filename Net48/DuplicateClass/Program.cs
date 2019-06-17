using System.IO;

namespace DuplicateClass
{
    public class Program
    {
        private static readonly string RootDirectory = Path.GetFullPath(@"..\..\..\NetCoreRepro");

        public static void Main(string[] args)
        {
            using (var fileWriter = File.CreateText(Path.Combine(RootDirectory, "IClassN.cs")))
            {
                fileWriter.WriteLine($"public class Base {{ public virtual void DoSomething() {{ }} }}");

                for (int i = 1; i <= 1000; ++i)
                {
                    fileWriter.WriteLine($"public class Derived{i} : Base {{ }}");
                }
            }
        }
    }
}
