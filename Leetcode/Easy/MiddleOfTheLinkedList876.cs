﻿namespace ComputitivePrograming.Leetcode.Easy
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

    /// <summary>
    /// Solution of the problem
    /// 876. Get the middle of a linked list
    /// </summary>
    public class MiddleOfTheLinkedList876
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

            temp = head;
            int middleLength = Math.Abs(length / 2);
            while (middleLength != 0)
            {
                temp = temp.next;
                middleLength--;
            }
            return temp;
        }
    }
}
