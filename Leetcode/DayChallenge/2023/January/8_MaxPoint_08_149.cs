using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class MaxPoint_08_149
    {
        public int Solution(int[][] points)
        {
            int max = 0;
            if (points == null || points.Length == 0) return 0;
            int n = points.Length;
            if (n == 1) return 1;
            for (int i = 0; i < n - 1; ++i)
            {
                Dictionary<int, Dictionary<int, int>> map = new Dictionary<int, Dictionary<int, int>>();
                int dup = 0, lclmax = 0;
                for (int j = i + 1; j < n; ++j)
                {
                    int x = points[j][0] - points[i][0];
                    int y = points[j][1] - points[i][1];
                    if (x == 0 && y == 0)
                    {
                        ++dup;
                        continue;
                    }

                    int gcd = Gcd(x, y);
                    x /= gcd;
                    y /= gcd;

                    if (!map.ContainsKey(x)) 
                        map[x] = new Dictionary<int, int>();

                    if (!map.GetValueOrDefault(x).ContainsKey(y))
                        map.GetValueOrDefault(x)[y] = 0;

                    map.GetValueOrDefault(x)[y] = map.GetValueOrDefault(x).GetValueOrDefault(y) + 1;
                    lclmax = Math.Max(lclmax, map.GetValueOrDefault(x).GetValueOrDefault(y));
                }
                max = Math.Max(max, dup + lclmax + 1);
            }
            return max;
        }

        private int Gcd(int a, int b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }
    }
}
