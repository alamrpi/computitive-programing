namespace ComputitivePrograming.Leetcode.Medium
{
    public class CloseStrings
    {
        public bool Solution(string word1, string word2)
        {
            if(word1.Length != word2.Length)
                return false;

            int[] w1 = new int[26];
            int[] w2 = new int[26];

            foreach (var c in word1)
            {
                int freq = c - 'a';
                w1[c - 'a']++;
            }
            
            foreach (var c in word2)
                w2[c - 'a']++;

            for (int i = 0; i < 26; i++)
            {
                if ((w1[i] == 0 && w2[i] != 0) || (w2[i] == 0 && w1[i] != 0))
                    return false;
            }
            var sortedW1 = w1.OrderBy(x => x);
            var sortedW2 = w2.OrderBy(x => x);
            return Enumerable.SequenceEqual(sortedW1, sortedW2);
        }
    }
}
