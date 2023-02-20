using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Day100.Day1
{
    public class Node
    {
        public int val { get; set; }
        public int pos { get; set; }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<Node> list = new List<Node>();
            int n = nums.Length;

            //Step 1:
            //Convert vector from INT to Node
            for (int i = 0; i < n; i++)
            {
                Node nn = new Node();
                nn.val = nums[i];
                nn.pos = i;
                list.Add(nn);
            }

            //Step 2:
            //Sort the list based on Value;
            list = list.OrderBy(x => x.val).ToList();

            //Step 3:
            // Compare using Binary Search
            int[] ans = new int[2];
            int start = 0, end = n - 1;

            while (start < end)
            {
                int sum = list[start].val + list[end].val;
                if (sum == target)
                {
                    ans = new int[] { list[start].pos, list[end].pos };
                    break;
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return ans;
        }
    }
}
