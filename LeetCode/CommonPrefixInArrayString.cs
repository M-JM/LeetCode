using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".




//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.


//Constraints:

//1 <= strs.length <= 200
//0 <= strs[i].length <= 200
//strs[i] consists of only lower-case English letters.


    public class CommonPrefixInArrayString
    {
        public string LongestCommonPrefixMySolution(string[] strs)
        {
            if(strs.Length == 1)
            {
                return strs[0];
            }
            string check = strs.OrderBy(x => x.Length).First();
            List<string> toCompareStrings = strs.ToList();
            toCompareStrings.Remove(check);
            string result = "";
            List<char> list = check.ToCharArray().ToList();

            for (int i = 0; i < list.Count; i++)
            {
                int counter = 0;
                bool looping = true;
            
                    foreach (string str in toCompareStrings)
                    {
                        if (list[i] == str[i])
                        {
                            counter++;
                            if (counter == toCompareStrings.Count)
                            {
                                result += str[i];
                            }
                        }
                        else
                        {
                            looping = false;
                            break;
                        }

                    }
                if (!looping)
                {
                    break;
                }
                }

            return result;

        }

        public string LongestCommonPrefix(string[] strs)
        {

            if (strs == null || strs.Length == 0)
                return "";

            string lcp = strs[0];
            int minLen = lcp.Length;
            foreach (var word in strs)
            {
                int j = 0;
                while (j < lcp.Length && j < word.Length && lcp[j] == word[j])
                    j++;

                minLen = Math.Min(minLen, j);
            }

            return strs[0].Substring(0, minLen);
        }


    }
}

