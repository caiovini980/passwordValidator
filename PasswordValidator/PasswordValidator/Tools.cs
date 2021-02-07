using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordValidator
{
    class Tools
    {
        public static bool Contains(string input, string toCheck)
        {
            List<char> hasItem = new List<char>();

            char[] arrayCheck = toCheck.ToCharArray(0, toCheck.Length);

            foreach (var item in arrayCheck)
            {
                if (input.Contains(item) == true)
                {
                    hasItem.Add(item);
                }
            }

            if (hasItem.Count > 0)
            {
                return true;
            } else {
                return false;
            }
        }

        public static string GenerateRandomPassword(string uppercase, string lowercase, string digits, string specialChars)
        {
            Random random = new Random();

            char[] uppers = uppercase.ToCharArray(0, uppercase.Length);
            char[] lowers = lowercase.ToCharArray(0, lowercase.Length);
            char[] numbers = digits.ToCharArray(0, digits.Length);
            char[] special = specialChars.ToCharArray(0, specialChars.Length);

            int randomUpper = random.Next(uppers.Length);
            int randomLower = random.Next(lowers.Length);
            int randomNumber = random.Next(numbers.Length);
            int randomSpecial = random.Next(special.Length);

            List<char> newPassword = new List<char>();

            for (int i = 0; i < 2; i++)
            {
                newPassword.Add(uppers[randomUpper]);
                newPassword.Add(lowers[randomLower]);
                newPassword.Add(numbers[randomNumber]);
                newPassword.Add(special[randomSpecial]);
            }

            return newPassword.ToString();
        }
    }
}
