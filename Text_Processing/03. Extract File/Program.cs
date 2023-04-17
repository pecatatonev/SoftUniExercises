using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\").ToArray();

            string file = path[path.Length - 1];

            string[] fileNameWithExtension = file.Split(".").ToArray();

            Console.WriteLine($"File name: {fileNameWithExtension[0]}");
            Console.WriteLine($"File extension: {fileNameWithExtension[1]}");
        }
    }
}
