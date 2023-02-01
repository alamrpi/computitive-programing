using ComputitivePrograming.Leetcode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.DayChallenge._2023.January
{
    internal class Preorder_Traversal
    {
        public IList<int> Solution(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            List<int> ans = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                root = stack.Pop();
                ans.Add(root.val);
                if (root.right != null)
                    stack.Push(root.right);
                if (root.left != null)
                    stack.Push(root.left);
            }

            return ans;
        }
    }
}
