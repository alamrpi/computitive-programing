using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Easy
{
    public class RemoveDuplicateFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                    nums[j++] = nums[i];
            }
            nums[j++] = nums[nums.Length - 1];
            return j;
        }
    }
}
