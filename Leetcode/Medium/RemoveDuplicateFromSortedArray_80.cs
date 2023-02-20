using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Medium
{
    public class RemoveDuplicateFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length < 3)
                return nums.Length;

            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i + 2 <= nums.Length - 1 && nums[i] != nums[i + 2])
                    nums[j++] = nums[i];
            }
            nums[j++] = nums[nums.Length - 2];
            nums[j++] = nums[nums.Length - 1];
            return j;
        }
    }
}
