using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Medium
{
    /// <summary>
    /// 2095. Delete am item in at middle of the linked list.
    /// </summary>
    public class DeleteMiddleOfTheLinkedList2095
    {
        public ListNode Solution(ListNode head)
        {
            int length = 0;
            ListNode temp = head;
            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

           if(length > 1)
            {
                temp = head;
                int middleLength = Math.Abs(length / 2);

                int i = 1;
                while (i < middleLength)
                {
                    temp = temp.next;
                    i++;
                }
                temp.next = temp.next.next;
                return head;
            }
            else
            {
                head = null;
                return head;
            }
        }
    }
}
