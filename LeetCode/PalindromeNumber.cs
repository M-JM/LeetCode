using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//Given an integer x, return true if x is palindrome integer.

//An integer is a palindrome when it reads the same backward as forward.

//For example, 121 is a palindrome while 123 is not.


//Example 1:

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.
//Example 2:

//Input: x = -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
//Example 3:

//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left. Therefore it is not a palindrome.


//Constraints:

//-231 <= x <= 231 - 1

    public class PalindromeNumber
    {
        public bool IsPalindromeMySolution(int x)
        {
            if (x < 0)
            {
                return false;
            }

            string palindrome = x.ToString();
            var toReverse = palindrome.ToCharArray().Reverse();
            string palindromeReversed = new String(toReverse.ToArray());

            return String.Equals(palindrome, palindromeReversed);
              

    }

        public bool IsPalindromeWithoutStringConversion(int x)
        {
            int rev = 0, temp = x;
            while (temp > 0)
            {
                rev = rev * 10 + temp % 10;
                temp /= 10;
            }
            return x == rev;

        }
        public bool IsPalindromeWithoutAdditionalString(int x)
        {
            string str = x.ToString();
            int low = 0;
            while (low < str.Length - low - 1)
            {
                if (str[low] != str[str.Length - low - 1])
                    return false;
                low++;
            }
            return true;
        }

    }
}
