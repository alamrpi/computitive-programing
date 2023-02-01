using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Easy
{
    internal class RemoveDuplicatesSortedList
    {
        public ListNode Solution(ListNode head)
        {
            if (head == null)
                return head;

            ListNode newList = new ListNode(head.val);
            ListNode tail = newList;
            while (head != null)
            {
                if(tail.val != head.val)
                {
                    tail.next = new ListNode(head.val);
                    tail = tail.next;
                }

                head = head.next;
            }

            return newList;
        }
    }
}
