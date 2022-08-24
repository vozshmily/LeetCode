/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode();
        var temp = head;
        while (list1 != null || list2 != null)
        {
            var a = list1?.val ?? int.MaxValue;
            var b = list2?.val ?? int.MaxValue;

            if (a > b)
            {
                temp.next = list2;
                if (list2 != null)
                {
                    list2 = list2.next;
                }
            }
            else
            {
                temp.next = list1;
                if (list1 != null)
                {
                    list1 = list1.next;
                }
            }

            temp = temp.next;
        }

        return head.next;
    }
}