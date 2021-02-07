using System;

namespace PasswordValidator
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Project name: Password validator
            Author: Caio Aguiar
            */

            //Variables to check
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "@*_-#";

            //Get the user's input
            Console.WriteLine("Please, digit a password: ");
            string userPassword = Console.ReadLine();

            //score variable
            int score = 0;

            //check if the password have the minimum length
            if (userPassword.Length >= minLength)
            {
                score++;
            }

            //check if it contains uppercase letters
            bool hasUppercase = Tools.Contains(userPassword, uppercase);
            if (hasUppercase)
            {
                score++;
            }
            
            //check if it has lowercase letters
            bool hasLowercase = Tools.Contains(userPassword, lowercase);
            if (hasLowercase)
            {
                score++;
            }

            //check if it has any number
            bool hasNumber = Tools.Contains(userPassword, digits);
            if (hasNumber)
            {
                score++;
            }

            //check if it has any special character
            bool hasSpecialChar = Tools.Contains(userPassword, specialChars);
            if (hasSpecialChar)
            {
                score++;
            }
            else
            {
                score--;
                Console.WriteLine("No valid special character found. The acceptables are: '@', '*', '_', '-' or '#'.");
            }

            //check if the user is prego
            if (userPassword == "password" || userPassword == "1234")
            {
                score = 0;
            }

            Console.WriteLine(score);

            switch (score)
            {
                case 1:
                    Console.WriteLine("Password Status: WEAK");
                    break;

                case 2:
                    Console.WriteLine("Password Status: MEDIUM");
                    break;

                case 3:
                    Console.WriteLine("Password Status: STRONG");
                    break;

                default:
                if (score > 3)
                {
                    Console.WriteLine("Password Status: BRAVE");
                    break;
                }
                else
                {
                    Console.WriteLine("The password doesn’t meet any of the standards");
                    break;
                }
            }
        }
    }
}
