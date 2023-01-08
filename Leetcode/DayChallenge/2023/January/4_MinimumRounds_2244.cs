using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class MinimumRounds
    {
        public int Solution(int[] tasks)
        {
            int ans = 0;
            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (int task in tasks)
                count[task] = count.GetValueOrDefault(task) + 1;

            // Freq = 1 -> impossible
            // Freq = 2 -> needs 1 round
            // Freq = 3 -> needs 1 round
            // Freq = 3k                           -> needs k rounds
            // Freq = 3k + 1 = 3 * (k - 1) + 2 * 2 -> needs k + 1 rounds
            // Freq = 3k + 2 = 3 * k       + 2 * 1 -> needs k + 1 rounds
            foreach (int freq in count.Values)
            {
                if (freq == 1)
                    return -1;
                else
                    ans += (freq + 2) / 3;
            }
            return ans;
        }
    }
}
