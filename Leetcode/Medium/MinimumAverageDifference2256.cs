namespace ComputitivePrograming.Leetcode.Medium
{
    public class MinimumAverageDifference2256
    {
        /// <summary>
        /// Wrong 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Solution(int[] nums)
        {
            int left = 0;
            int right = nums.Sum();
            int minIndex = 0;
            int minDifference = Math.Abs(10 * 20);
            
            for (int i = 0; i < nums.Length; i++)
            {
                int result;
                left += nums[i];
                right -= nums[i];

                if (i + 1 == nums.Length)
                    result = Math.Abs(left / (i + 1));
                else
                    result = Math.Abs((left / (i + 1)) - (right)/nums.Length - i - 1);

                if(result < minDifference)
                {
                    minDifference = result;
                    minIndex = i;
                }
            }

            return minIndex;

        }
    }
}
