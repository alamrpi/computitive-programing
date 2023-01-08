using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.HackerRank.Easy
{
    public class Pangrams
    {
        /// <summary>
        /// Time Complexity o(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Solution(string s)
        {
           
            int[] A = new int[26];

            for (int i = 0; i < 26; ++i)
                A[i] = 0;

            s = s.ToLower();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != ' ')
                {
                    A[s[i] - 'a'] = 1;
                }
            }

            int j;
            for (j = 0; j < 26; ++j)
                if (A[j] == 0)
                    break;

            return j == 26 ? "pangram" : "not pangram";
              
        }
    }
}
