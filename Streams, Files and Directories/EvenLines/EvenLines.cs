namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader streamReader = new StreamReader(inputFilePath);
            int counter = 0;
            StringBuilder output = new StringBuilder();
            string line = string.Empty;
            string[] array = null;
            string textReversed = string.Empty;
            using (streamReader)
            {

                while (line != null)
                {
                    line = streamReader.ReadLine();
                    counter++;
                    if (counter % 2 != 0)
                    {
                        output.AppendLine(line);
                        output.Replace('-', '@');
                        output.Replace(',', '@');
                        output.Replace('.', '@');
                        output.Replace('!', '@');
                        output.Replace('?', '@');

                        string text = output.ToString();
                        output.Clear();
                        array = text.Split();
                        Array.Reverse(array);

                        Console.WriteLine(string.Join(" ", array));
                    }
                }
            }

            return textReversed;
        }
    }
}
