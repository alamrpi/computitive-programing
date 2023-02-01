using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Easy
{
    internal class ConvertBinaryNumberToInteger
    {
        public int Solution(ListNode head)
        {
            int val = 0;

            while (head != null)
            {
                val = val * 2 + head.val;
                head = head.next;
            }
            return val;
        }
    }
}
