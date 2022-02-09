using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.



//Example 1:

//Input: num = 38
//Output: 2
//Explanation: The process is
//38 --> 3 + 8 --> 11
//11 --> 1 + 1 --> 2 
//Since 2 has only one digit, return it.
//Example 2:

//Input: num = 0
//Output: 0
 

//Constraints:

//0 <= num <= 231 - 1
 

//Follow up: Could you do it without any loop/recursion in O(1) runtime?

    public  class AddDigitsTillOneDigitLeft
    {
        public int AddDigitsMySolution(int num)
        {

            int valueDecontructToBase10 = num;
            List<int> numbers = new();
            while (valueDecontructToBase10 > 0)
            {
                numbers.Add(valueDecontructToBase10 % 10);
                valueDecontructToBase10 /= 10;
            }
            numbers.Reverse();
          
         

            if (numbers.Count != 1)
            {
                int result = numbers.Sum();
                return AddDigitsMySolution(result);
            }
                return numbers.First();
        }


        // O(1) Time and Space complexity.
        // Gebaseerd op Digital Root formula.
        //
        public int AddDigitsOptimalSolution(int num) => 1 + (num - 1) % 9;
    }
}
