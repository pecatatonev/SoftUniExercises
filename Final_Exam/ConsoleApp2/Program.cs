using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isg = "Hello World";
            Console.WriteLine(isg.Substring(3,4));
        }
       
    }
}
