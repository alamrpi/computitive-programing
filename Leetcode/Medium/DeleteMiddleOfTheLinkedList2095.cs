using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Medium
{
    /// <summary>
    /// Linked List Node
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

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
