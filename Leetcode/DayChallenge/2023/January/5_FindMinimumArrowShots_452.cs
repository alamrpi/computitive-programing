using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class FindMinimumArrowShots
    {
        public int Solution(int[][] points)
        {
            Comparer<int> comparer = Comparer<int>.Default;
            Array.Sort(points, (x, y) => comparer.Compare(x[1], y[1]));
            int end = points[0][1];
            int arrow = 1;
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i][0] <= end)
                    continue;
                else
                {
                    end = points[i][1];
                    arrow++;
                }  
            }
            return arrow;
        }
    }
}
