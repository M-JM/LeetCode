using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveElement
    {
        public int RemoveElementAt(int[] nums, int val)
        {
            for (int i = 0; i < nums.Count(); i++)
            {
                if(nums[i] == val)
                {
                    nums[i] = -1;
                }
            }

            Array.Sort(nums);
            Array.Reverse(nums);
            Console.WriteLine(nums);

            return nums.Where(x => x != -1).Count();
        }

    }
}
