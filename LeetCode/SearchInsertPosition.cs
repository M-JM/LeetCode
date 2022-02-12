using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    index = i;
                    break;
                   
                }
            }
            if (index != -1)
            {
                return index;
            }
            nums = nums.Append(target).ToArray<int>();
            Array.Sort(nums);

            return SearchInsert(nums, target);
          
        }

        public void AppendTarget(int[] nums, int target)
        {
            nums = nums.Append(target).ToArray<int>();
            Array.Sort(nums);

            SearchInsert(nums, target);
        }

    }
}
