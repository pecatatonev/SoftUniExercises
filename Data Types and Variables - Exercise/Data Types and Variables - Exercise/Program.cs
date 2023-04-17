

namespace Data_Types_and_Variables___Exercise
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fotrhNum = int.Parse(Console.ReadLine());

            int sum = secondNum;

            sum += firstNum;
            sum /= thirdNum;
            sum *= fotrhNum;

            Console.WriteLine(sum);
        }
    }
}
