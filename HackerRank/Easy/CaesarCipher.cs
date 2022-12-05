using System.Text;
using System;
using System.Text.RegularExpressions;

namespace ComputitivePrograming.HackerRank.Easy
{
    public class CaesarCipher
    {
        public string Solution(string s, int k)
        {
            
            StringBuilder builder = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                char temp = s[i];
                bool upperCase = char.IsUpper(temp);
                if (char.IsLetter(temp))
                {
                    temp += (char)(k % 26);
                    if (!char.IsLetter(temp) || (upperCase && !char.IsUpper(temp)))
                    {
                        temp = (char)(temp - 26);
                    }
                }
                builder.Append(temp);
            }

            return builder.ToString();
        }
    }
}
