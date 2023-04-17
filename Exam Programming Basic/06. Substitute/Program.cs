using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine()); //1
            int L = int.Parse(Console.ReadLine()); //2
            int M = int.Parse(Console.ReadLine()); //1 
            int N = int.Parse(Console.ReadLine()); //2

            int counter = 0;

            for (int i = K; i <= 8; i++)
            {
                for (int j = 9; j >= L; j--)
                { 
                    for (int p = M; p <= 8; p++)
                    { 
                        for (int v = 9; v >= N; v--)
                        {
                            if (j % 2 != 0 && v % 2 != 0)
                            {
                                if ( i % 2 == 0 && p % 2 == 0)
                                {
                                    if (i==p && j==v)
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{i}{j} - {p}{v}");
                                        counter++;
                                    }
                                    if (counter>=6)
                                    {
                                        return;
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
