using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Hard
{
    public class MedianOfTwoSortedArrays4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Check if num1 is smaller than num2
            // If not, then we will swap num1 with num2
            if (nums1.Length > nums2.Length)
            {
                (nums2, nums1) = (nums1, nums2);
            }
            // Lengths of two arrays
            int m = nums1.Length;
            int n = nums2.Length;
            // Pointers for binary search
            int start = 0;
            int end = m;
            // Binary search starts from here
            while (start <= end)
            {
                // Partitions of both the array
                int partitionNums1 = (start + end) / 2;
                int partitionNums2 = (m + n + 1) / 2 - partitionNums1;
                // Edge cases
                // If there are no elements left on the left side after partition
                int maxLeftNums1 = partitionNums1 == 0 ? int.MinValue : nums1[partitionNums1 - 1];
                // If there are no elements left on the right side after partition
                int minRightNums1 = partitionNums1 == m ? int.MaxValue : nums1[partitionNums1];
                // Similarly for nums2
                int maxLeftNums2 = partitionNums2 == 0 ? int.MinValue : nums2[partitionNums2 - 1];
                int minRightNums2 = partitionNums2 == n ? int.MaxValue : nums2[partitionNums2];
                // Check if we have found the match
                if (maxLeftNums1 <= minRightNums2 && maxLeftNums2 <= minRightNums1)
                {
                    // Check if the combined array is of even/odd length
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(maxLeftNums1, maxLeftNums2) + Math.Max(minRightNums1, minRightNums2)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftNums1, maxLeftNums2);
                    }
                }
                // If we are too far on the right, we need to go to left side
                else if (maxLeftNums1 > minRightNums2)
                {
                    end = partitionNums1 - 1;
                }
                // If we are too far on the left, we need to go to right side
                else
                {
                    start = partitionNums1 + 1;
                }
            }
            // If we reach here, it means the arrays are not sorted
            throw new FormatException();
        }
    }
}
