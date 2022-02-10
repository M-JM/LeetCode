using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPalindromeString
    {
        public bool IsPalindrome(string s)
        {
            string sToLower = s.ToLowerInvariant();
            StringBuilder sb = new StringBuilder();
            foreach (char c in sToLower)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }
            String withoutSpecialChars = sb.ToString();
            char[] reversedwithoutSpecialChars = withoutSpecialChars.ToCharArray();
            Array.Reverse(reversedwithoutSpecialChars);
            string stringReversedwithoutSpecialChars = new string(reversedwithoutSpecialChars);
            bool test = String.Equals(withoutSpecialChars, stringReversedwithoutSpecialChars, StringComparison.InvariantCultureIgnoreCase);
            return test;
        }
    }
}
