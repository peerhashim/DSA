using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.arrays
{
    static class Arrays
    {
        // ARRAYS - TWO SUM - leetcode 1 - https://leetcode.com/problems/two-sum/

        //  BRUTE FORCE
        static public int[] TwoSumB(int[] nums, int target)
        {
            int last_index = nums.Length - 1;
            int slow = 0;
            int fast = 1;
            for (; slow <= last_index; slow++)
            {
                for (; fast <= last_index; fast++)
                {
                    if (nums[slow] + nums[fast] == target)
                    {
                        return new[] { slow, fast };
                    }
                }
                fast = slow + 2;
            }

            return new[] { -1, -1 };
        }
        //Time Complexity = O(n²)
        //Space Complexity = O(1)

        // OPTIMIZED - using dictionary
        static public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> pastValues = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int defference = target - nums[i];
                if (pastValues.ContainsKey(defference))
                {
                    return new[] { i, pastValues[defference] };
                }
                else
                {
                    pastValues[nums[i] ] = i ;
                }
            }
            return new[] { -1, -1 };
        }
    }
}
