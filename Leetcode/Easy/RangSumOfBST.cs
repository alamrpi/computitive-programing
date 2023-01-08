using ComputitivePrograming.Leetcode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Easy
{
    public class RangSumOfBST
    {
        public int Solution(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0; 
            if (root.val < L)
                return Solution(root.right, L, R); 
            if (root.val > R)
                return Solution(root.left, L, R);

            return root.val + Solution(root.right, L, R) + Solution(root.left, L, R); 
        }
    }
}
