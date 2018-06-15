using System.Collections.Generic;
using System.IO;

namespace Converter
{
    public static class FileWriter
    {
        public static void WriteFile(IReadOnlyList<string> lines, string path)
        {
            using (var file = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}