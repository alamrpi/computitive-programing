using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Easy
{
    public class PalindromNumber9
    {
        public bool Solution(int x)
        {
            int r, sum = 0, temp;
            temp = x;
            while (x > 0)
            {
                r = x % 10;
                sum = (sum * 10) + r;
                x /= 10;
            }
            return temp == sum;
        }
    }
}
