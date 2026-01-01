using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.arrays
{
    static class Arrays
    {
        // arrays - two sum
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
    }
}
