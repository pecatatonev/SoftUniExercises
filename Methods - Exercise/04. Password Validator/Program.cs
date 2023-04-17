using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isCorrect1 = true;
            bool isCorrect2 = true;
            bool isCorrect3 = true;
            isCorrect1 = PasswordLenght(password, isCorrect1);
            isCorrect2 = PasswordLettersAndDigits(password, isCorrect2);
            isCorrect3 = LeastTwoDigits(password, isCorrect3);

            if (isCorrect1 == true  && isCorrect2 == true && isCorrect3 == true )
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool LeastTwoDigits(string password,bool isCorrect3)
        {
            char currCh = ' ';
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {

                currCh = password[i];
                bool isDigit = char.IsDigit(currCh);
                if (isDigit == true)
                {
                    count++;
                }

            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
                
            }
            return true;
            
        }

        private static bool PasswordLettersAndDigits(string password, bool isCorrect2)
        {
            bool isAlpha = password.All(Char.IsLetterOrDigit);
            if (isAlpha == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            return true;
        }

        private static bool PasswordLenght(string password, bool isCorrect1)
        {
            if (password.Length > 10 || password.Length < 6)
            {
                
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
    }
}
