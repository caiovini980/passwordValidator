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
    }
}
