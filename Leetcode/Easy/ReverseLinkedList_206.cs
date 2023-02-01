using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Easy
{
    internal class ReverseLinkedList
    {
        public ListNode Solution(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode curr = head, prev = null;

            while (curr != null)
            {
                ListNode forw = curr.next;
                curr.next = prev;
                prev = curr;
                curr = forw;
            }
            return prev;
        }
    }
}
