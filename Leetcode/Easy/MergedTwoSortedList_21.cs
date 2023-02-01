using ComputitivePrograming.Leetcode.LinkedList;

namespace ComputitivePrograming.Leetcode.Easy
{
    internal class MergedTwoSortedList
    {
        public ListNode Solution(ListNode list1, ListNode list2)
        {
            var newLinkedList = new ListNode(-1);
            var tail = newLinkedList;
            while (list1 != null && list2.next != null)
            {
                if(list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }

            if(list1 != null) 
                tail.next = list1;
            if(list2 != null)
                tail.next = list2;
            
            return newLinkedList.next;
        }
    }
}
