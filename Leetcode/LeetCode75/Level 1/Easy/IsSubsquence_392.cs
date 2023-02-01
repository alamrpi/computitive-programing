using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.LeetCode75.Level_1.Easy
{
    internal class IsSubsquence
    {
        public bool Solution(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int i = 0;
            foreach (var c in t.ToCharArray())
            {
                if (s[i] == c && ++i == s.Length)
                    return true;
            }
            return false;
        }
    }
}
