using System.Text;

namespace ComputitivePrograming.Leetcode.Easy
{
    internal class ReverseVowelsOfString
    {
        public string Solution(string s)
        {
            const string vowels = "aeiouAEIOU";
            int left = 0, right = s.Length - 1;
            StringBuilder sb = new StringBuilder(s);

            while (left < right)
            {
                //check left char is vowels
                while (left < right && !vowels.Contains(sb[left]))
                    ++left;
                
                //check left char is vowels
                while (left < right && !vowels.Contains(sb[right]))
                    --right;

                sb[left] = s[right];
                sb[right] = s[left];
                ++left;
                --right;
            }

            return sb.ToString();
        }
    }
}
