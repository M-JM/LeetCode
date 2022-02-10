using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.

//Given a string s, return true if it is a palindrome, or false otherwise.



//Example 1:

//Input: s = "A man, a plan, a canal: Panama"
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.
//Example 2:

//Input: s = "race a car"
//Output: false
//Explanation: "raceacar" is not a palindrome.
//Example 3:

//Input: s = " "
//Output: true
//Explanation: s is an empty string "" after removing non-alphanumeric characters.
//Since an empty string reads the same forward and backward, it is a palindrome.



//Constraints:

//1 <= s.length <= 2 * 105
//s consists only of printable ASCII characters.

    public class IsPalindromeString
    {
        public bool IsPalindromeMySolution(string s)
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

//        A simple two-pointer linear scan C# solution.

//Time Complexity: O(n)
//Space Complexity: O(1)

        public bool IsPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!Char.IsLetterOrDigit(s[start]))
                {
                    start++;
                    continue;
                }

                if (!Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }

                if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
