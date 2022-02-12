using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PlusOneArray
    {
        public int[] PlusOne(int[] digits)
        {
            decimal totalnum = 0;
            List<int> intArray = new List<int>();
            for (decimal i = 0; i < digits.Length; i++)
            {
                decimal currentTotal = totalnum;
                decimal base10 = currentTotal * 10;
                decimal currentdigit = digits[(int)i];
                decimal newCurrentTotal = base10 + currentdigit;
                totalnum = newCurrentTotal; 
               
            }
            totalnum += 1; 

            for (; totalnum > 0; totalnum /= 10)
            {
                decimal digit = totalnum % 10;
                intArray.Add(((int)digit));
            }
            intArray.Reverse();

            return intArray.ToArray();
        }

    }
}
