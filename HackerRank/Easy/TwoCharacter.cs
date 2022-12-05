using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.HackerRank.Easy
{
    public class TwoCharacter
    {
        public int Solution(string s)
        {
            int ans = 0;
            for (char i = 'a'; i < 'z'; i++)
            {
                for (char j = 'b'; j <= 'z'; j++)
                {
                    int result = validSize(s, i, j);
                    if (result > ans)
                        ans = result;
                }
            }
            return ans;
        }

        public int validSize(string s, char first, char second)
        {
            string ans = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == first || s[i] == second)
                {
                    if (ans.Length > 0 && ans[ans.Length - 1] == s[i]) 
                        return 0;
                    else
                        ans += s[i];
                }
            }
            if (ans.Length < 2)
                return 0;

            return ans.Length;
        }
    }
}
