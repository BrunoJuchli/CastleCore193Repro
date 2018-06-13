using System.Collections.Generic;
using System.IO;
using Converter;

namespace DuplicateClass
{
    public class Program
    {
        private static readonly string RootDirectory = Path.GetFullPath(@"..\..\..\CastleProblem");

        public static void Main(string[] args)
        {
            var filesToDuplicate = RetrieveFilesToDublicate(RootDirectory);
            foreach (var filePath in filesToDuplicate)
            {
                DuplicateFile(filePath, 1000);
            }
        }

        private static void DuplicateFile(string path, int count)
        {
            var fileName = Path.GetFileName(path);
            var fileContent = FileReader.ReadLines(path);
            string[] fileParts = fileName.Split('.');
            var className = fileParts[0];
            for (int i = 1; i <= count; i++)
            {
                string newFileName = fileParts[0] + i + "." + fileParts[1];
                string newClassName = className + i;
                var newContent = new List<string>();
                var newPath = Path.Combine(Path.Combine(Path.GetDirectoryName(path), "Generated"), newFileName);
                for (int line = 0; line < fileContent.Count; line++)
                {
                    if (fileContent[line].Contains("public class " + className) || fileContent[line].Contains("public " + className + "()") || fileContent[line].Contains("public interface " + className))
                    {
                        newContent.Add(fileContent[line].Replace(className, newClassName));
                    }
                    else if (fileContent[line].Contains("Mock<IClass>"))
                    {
                        newContent.Add(fileContent[line].Replace("Mock<IClass", "Mock<IClass" + i));
                    }
                    else
                    {
                        newContent.Add(fileContent[line]);
                    }
                }

                FileWriter.WriteFile(newContent, newPath);
            }

        }

        public static IReadOnlyList<string> RetrieveFilesToDublicate(string basePath)
        {
            return Directory.GetFiles(basePath, "*.cs", SearchOption.TopDirectoryOnly);
        }
    }
}
