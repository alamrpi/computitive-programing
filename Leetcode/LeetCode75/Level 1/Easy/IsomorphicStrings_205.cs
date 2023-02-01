using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.LeetCode75.Level_1.Easy
{
    internal class IsomorphicStrings
    {
        public bool Solution(string s, string t)
        {
            Dictionary<char, char> m = new Dictionary<char, char>();
           
            if (t.Length != s.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (m.ContainsKey(c))
                {
                    if (!t[i].Equals(m.GetValueOrDefault(c)))
                        return false;
                }
                else
                {
                    if (m.ContainsValue(t[i]))
                        return false;

                    m[c] = t[i];
                }
            }
            return true;
        }
    }
}
