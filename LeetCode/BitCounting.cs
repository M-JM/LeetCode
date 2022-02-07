using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class BitCounting
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Where(x => x == '1').Count(); 
        }

    }
}
