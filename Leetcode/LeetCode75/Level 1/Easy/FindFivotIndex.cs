namespace ComputitivePrograming.Leetcode.LeetCode75.Level_1.Easy
{
    public class FindFivotIndex
    {
        public int Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int left = 0, right = 0;
                if (i != 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                        left += nums[j];
                }
              
                if(i != nums.Length - 1)
                {
                    for (int k = i + 1; k < nums.Length; k++)
                        right += nums[k]; 
                }

                if(left == right)
                    return i;

            }
            return -1;
        }
    }
}
