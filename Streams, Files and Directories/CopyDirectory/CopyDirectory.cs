namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath,true);
            }

            Directory.CreateDirectory(outputPath);

            string[] filesNames = Directory.GetFiles(inputPath);

            foreach (var file in filesNames)
            {
                string fileN = Path.GetFileName(file);

                string destination = Path.Combine(outputPath, fileN);

                File.Copy(file, destination);
            }
        }
    }
}
