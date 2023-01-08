using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.LeetCode75.Level_1.Easy
{
    public class SumOf1DArray
    {
        /// <summary>
        /// Time Complexity o(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    result[i] = nums[i];
                else
                    result[i] = nums[i] + result[i-1];
            }
            return result;
        }
    }
}
