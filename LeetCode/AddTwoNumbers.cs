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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode head = null;
        int carry = 0;

        while (l1 != null && l2 != null)
        {
            int sum = carry + l1.val + l2.val;

            carry = (sum >= 10) ? 1 : 0;
            sum = sum % 10;
            InsertAtEnd(ref head, new ListNode(sum));
            l1 = l1.next; l2 = l2.next;
        }

        while (l1 != null)
        {
            int sum = carry + l1.val;

            carry = (sum >= 10) ? 1 : 0;
            sum = sum % 10;
            InsertAtEnd(ref head, new ListNode(sum));
            l1 = l1.next;
        }

        while (l2 != null)
        {
            int sum = carry + l2.val;
            carry = (sum >= 10) ? 1 : 0;
            sum = sum % 10;
            InsertAtEnd(ref head, new ListNode(sum));
            l2 = l2.next;
        }
        if (carry > 0)
            InsertAtEnd(ref head, new ListNode(carry));
        return head;
    }
    void InsertAtEnd(ref ListNode head, ListNode newNode)
    {
        var temp = head;
        if (temp == null)
        {
            head = newNode;
            return;
        }
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }
}
/*
public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode head = null;
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            int sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);

            carry = (sum >= 10) ? 1 : 0;
            sum = sum % 10;

            InsertAtEnd(ref head, new ListNode(sum));
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }

        if (carry > 0)
            InsertAtEnd(ref head, new ListNode(carry));

        return head;
    }
    void InsertAtEnd(ref ListNode head, ListNode newNode)
    {
        var temp = head;
        if (temp == null)
        {
            head = newNode;
            return;
        }
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }
*/