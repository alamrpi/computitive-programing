using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class GasStation
    {
        public int Solution(int[] gas, int[] cost)
        {
            if ((gas.Sum() - cost.Sum()) < 0) return -1;

            int ans = 0, sum = 0;

            for (int i = 0; i < gas.Length; ++i)
            {
                sum += gas[i] - cost[i];
                if (sum < 0)
                {
                    sum = 0;
                    ans = i + 1;
                }
            }

            return ans;
        }
    }
}
