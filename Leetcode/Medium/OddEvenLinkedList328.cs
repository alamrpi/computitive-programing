using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Medium
{
    /// <summary>
    /// 328. Odd Even Linked List
    /// </summary>
    public class OddEvenLinkedList328
    {
        public ListNode Solution(ListNode head)
        {
            ListNode oddList = new ListNode(-1);
            ListNode evenList = new ListNode(-1);
            ListNode temOdd = oddList;
            ListNode tempEven = evenList;

            int i = 1;
            while (head != null)
            {
                if (i % 2 != 0)
                {
                    temOdd.next = head;
                    temOdd = head;
                }
                else
                {
                    tempEven.next = head;
                    tempEven = head;
                }
                head = head.next;
                i++;
            }
            tempEven.next = null;
            temOdd.next = evenList.next;
            return oddList.next;
        }
    }
}
