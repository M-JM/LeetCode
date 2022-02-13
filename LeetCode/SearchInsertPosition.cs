using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

//    Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.

//You must write an algorithm with O(log n) runtime complexity.



//Example 1:

//Input: nums = [1, 3, 5, 6], target = 5
//Output: 2
//Example 2:


//Input: nums = [1, 3, 5, 6], target = 2
//Output: 1
//Example 3:


//Input: nums = [1, 3, 5, 6], target = 7
//Output: 4



//Constraints:

//1 <= nums.length <= 104
//-104 <= nums[i] <= 104
//nums contains distinct values sorted in ascending order.
//-104 <= target <= 104

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
        public int SearchInsertSolution(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int i = 0,
                j = nums.Length - 1;

            while (i <= j)
            {
                int m = j + (i - j) / 2;

                if (nums[m] == target)
                    return m;
                else if (nums[m] < target)
                    i = m + 1;
                else
                    j = m - 1;
            }

            return i;
        }


    }
}
