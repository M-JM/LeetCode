using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class StrStrProblem
    {
        public int StrStr(string haystack, string needle)
        {
            int needleLength = needle.Length;
            int haystackLength = haystack.Length;

            if (String.IsNullOrEmpty(needle))
                return 0;

            if (needle.Length > haystack.Length)
                return -1;

           
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
