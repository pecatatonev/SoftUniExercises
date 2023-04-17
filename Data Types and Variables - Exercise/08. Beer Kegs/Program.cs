using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            double maxValue = double.MinValue;
            string bigModel = string.Empty;

            while (n>0)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                result = Math.PI * Math.Pow(radius , 2) * height;
                
                if (result > maxValue)
                {
                    maxValue = result;
                    bigModel = model;
                }
                
                n--;
            }
            Console.WriteLine(bigModel);
        }
    }
}
