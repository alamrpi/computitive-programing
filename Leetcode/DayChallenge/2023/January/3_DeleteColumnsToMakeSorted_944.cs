namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class DeleteColumnsToMakeSorted
    {
        public int Solution(string[] strs)
        {
            int n = strs.Length;
            if (n == 0) 
                return 0;
            int m = strs[0].Length;
            int ans = 0;
            for (int col = 0; col < m; col++)
            {
                ans += NotSorted(strs, col, n);
            }
            return ans;
        }
        public int NotSorted(string[] strs, int col, int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (strs[i][col] < strs[i - 1][col])
                    return 1;
            }
            return 0;
        }
    }
}
