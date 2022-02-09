using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

  //An input string is valid if:

  //Open brackets must be closed by the same type of brackets.
  //Open brackets must be closed in the correct order.

  //TODO Solve using a Stack to Pop and push

    public class ValidParetheses
    {
        public bool IsValid(string s)
        {
            List<char> chars = s.ToCharArray().ToList();

            for (int i = 0; i < s.Length; i++)
            {
                // [ { } ]

                if(i+1 < chars.Count)
                {
                    switch (chars[i])
                    {
                        case '[':
                            if (chars[i + 1] == ')')
                                return false;
                            break;
                        case '(':
                            if (chars[i + 1] == ']')
                                return false;
                            break;
                        default:
                            break;
                    }
                }
              
            }


            if(s.Where(x => x =='(').Count() == s.Where(x => x ==')').Count() && s.Where(s => s =='[').Count() == s.Where(s=> s == ']').Count())
            {
                return true;
            }

            return false;
        }
    }
}
