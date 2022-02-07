using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static class FindTheDifference
    {
       public static char FindTheDifferenceOwnSolution(string s, string t)
            {

            char[] string1 = s.ToCharArray();
            char[] string2 = t.ToCharArray();
            char difference = '0';
            Array.Sort(string1);
            Array.Sort(string2);

            for (int i = 0; i < string1.Length; i++)
            {
                if(string2[i] != string1[i])
                {
                    difference = string2[i];
                    break;
                }
            }
            if(difference == '0')
            {
                difference = string2.LastOrDefault();
            }

            return difference;
            }


        public static char FindTheDifferenceOneLiner(string s, string t)
        {
            return (char)(t.Sum(c => c) - s.Sum(c => c));
        }



    }

   

}
