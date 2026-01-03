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
        //Time = O(n), Space = O(n)

        // BEST TIME TO BUY AND SELL STOCK - leetcode 121 - https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

        // BRUTE FORCE
        static public int MaxProfitB(int[] prices)
        {
            int maxProfit = 0;
            if (prices.Length == 1) return maxProfit;
            int i = 0;
            int j = 1;
            for (; i < prices.Length; i++)
            {
                for (; j < prices.Length; j++)
                {
                    int tempMax = prices[j] - prices[i];
                    if (tempMax > maxProfit)
                    {
                        maxProfit = tempMax;
                    }
                }
                j = i + 2;
            }

            return maxProfit;
        }
        //Time Complexity = O(n²)
        //Space Complexity = O(1)

        // BESt TIME TO BUY AND SELL STOCK - OPTIMIZED
        static public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }


        // BEST TIME TO BUY AND SELL STOCK 2 - leetcode 122 - https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
        static public int MaxProfit2(int[] prices)
        {
            int MaxProfit = 0;
            int tempMax = 0;
            int i = 0;
            int j = 1;
            for (; i < prices.Length; i++)
            {
                for (; j < prices.Length; j++)
                {
                    if (prices[i] < prices[j])
                    {
                        tempMax = Math.Max(tempMax, prices[j] - prices[i]);
                    }
                }
                MaxProfit = MaxProfit + tempMax;
                tempMax = 0;
                j = i + 2;
            }
            return MaxProfit;
        }

    }
}
