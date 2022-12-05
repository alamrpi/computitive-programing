using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Medium
{
    /// <summary>
    /// 19. Delete nth child of the linked list from end of linked list.
    /// </summary>
    public class RemoveNthFromEndOfList19
    {
        public ListNode Solution(ListNode head, int n)
        {
            int length = 0;
            ListNode temp = head;
            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            if (length > 1)
            {
                temp = head;
                int middleLength = length - n;
                if (middleLength == 0)
                {
                    head = temp.next;
                }
                else
                {
                    int i = 1;
                    while (i < middleLength)
                    {
                        temp = temp.next;
                        i++;
                    }
                    temp.next = temp.next.next;
                }
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
