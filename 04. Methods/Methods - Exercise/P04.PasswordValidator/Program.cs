using System;
using System.Diagnostics.Tracing;

namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();

            bool isLengthValid = LengthOfPassword(password);
            bool isThereLettersAndDigit = PasswordContainsLettersAndDigits(password);
            bool isThereAtLeastTwoDigits = PasswordContainsAtLeastTwoDigits(password);

            if (isLengthValid == true && isThereLettersAndDigit == true && isThereAtLeastTwoDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool LengthOfPassword(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }

        static bool PasswordContainsLettersAndDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currChar = password[i];
                if (!((currChar >= 48 && currChar <= 57) || (currChar >= 65 && currChar <= 90) || (currChar >= 97 && currChar <= 122)))
                {
                    counter++;
                }
                
            }
            if (counter > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        static bool PasswordContainsAtLeastTwoDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currChar = password[i];
                if (currChar >= 48 && currChar <= 57)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }
    }
}
