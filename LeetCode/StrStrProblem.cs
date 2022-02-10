using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    Implement strStr().

//Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

//Clarification:

//What should we return when needle is an empty string? This is a great question to ask during an interview.

//For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().




//Example 1:

//Input: haystack = "hello", needle = "ll"
//Output: 2
//Example 2:

//Input: haystack = "aaaaa", needle = "bba"
//Output: -1
//Example 3:

//Input: haystack = "", needle = ""
//Output: 0



//Constraints:

//0 <= haystack.length, needle.length <= 5 * 104
//haystack and needle consist of only lower-case English characters.


    public class StrStrProblem
    {
        public int StrStr(string haystack, string needle)
        {
            int needleLength = needle.Length; // 3
            int haystackLength = haystack.Length; //10

            if (String.IsNullOrEmpty(needle))
                return 0;

            if (needle.Length > haystack.Length)
                return -1;

           // i < 9 - 3 + 1 = 7 
                for (int i = 0; i < haystackLength - needleLength + 1; i++)
                {
                    if (haystack.Substring(i, needleLength) == needle)
                    {
                        return i;
                    }
                }
                return -1;
           
        }

    }
}
