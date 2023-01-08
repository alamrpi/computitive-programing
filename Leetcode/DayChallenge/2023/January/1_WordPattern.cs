namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    public class Jan01_WordPattern
    {
        public bool Solution(string pattern, string s)
        {
            Dictionary<char, string> m = new Dictionary<char, string>();
            string[] words = s.Split(" ");

            if (pattern.Length != words.Length)
                return false;

            for (int i = 0; i < words.Length; i++)
            {
                char c = pattern[i];
                if (m.ContainsKey(c))
                {
                    if (!words[i].Equals(m.GetValueOrDefault(c))) 
                        return false;
                }
                else
                {
                    if (m.ContainsValue(words[i]))
                        return false; 

                    m[c] = words[i];
                }
            }
            return true;
        }
    }
}
