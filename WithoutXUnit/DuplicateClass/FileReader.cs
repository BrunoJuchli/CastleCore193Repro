using System.Collections.Generic;
using System.IO;

namespace Converter
{
    public static class FileReader
    {
        public static List<string> ReadLines(string path)
        {
            var lines = new List<string>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}