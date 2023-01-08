namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class MaxIceCream
    {
        public int Solution(int[] costs, int coins)
        {
            int iceCreams = 0;
            foreach (var item in costs.OrderBy(x => x))
            {
                if(coins == 0)
                    break;

                if(item <= coins)
                {
                    coins -= item;
                    iceCreams++;
                }
            }
            return iceCreams;
        }
    }
}
