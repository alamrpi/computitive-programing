using System.Text;

namespace ComputitivePrograming.Leetcode.Easy
{
    /// <summary>
    /// 1528. Shuffle String
    /// You are given a string s and an integer array indices of the same length. The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
    /// Return the shuffled string.
    /// </summary>
    internal class ShuffleString
    {
        public string Solution(string s, int[] indices)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < indices.Count(); i++)
            {
                sb[indices[i]] = s[i];
            }

            return sb.ToString();
        }
    }
}
