using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    Given a string s consisting of some words separated by some number of spaces, return the length of the last word in the string.

//A word is a maximal substring consisting of non-space characters only.



//Example 1:

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.
//Example 2:

//Input: s = "   fly me   to   the moon  "
//Output: 4
//Explanation: The last word is "moon" with length 4.
//Example 3:

//Input: s = "luffy is still joyboy"
//Output: 6
//Explanation: The last word is "joyboy" with length 6.
 

//Constraints:

//1 <= s.length <= 104
//s consists of only English letters and spaces ' '.
//There will be at least one word in s.


    public class LengthOfLastWordInString
    {
        public int LengthOfLastWord(string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;
            string[] vs = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int wordWithLength = vs[vs.Length-1].Length;
          
            return wordWithLength;

        }
    }
}
