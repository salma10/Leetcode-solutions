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
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode lo = new ListNode();
        ListNode hi = new ListNode();
        ListNode p1 = lo;
        ListNode p2 = hi;
        while (head != null)
        {
            if (head.val < x)
            {
                p1.next = head;
                p1 = p1.next;
            }
            else
            {
                p2.next = head;
                p2 = p2.next;
            }
            head = head.next;
        }
        p2.next = null;
        p1.next = hi.next;
        return lo.next;
    }
}