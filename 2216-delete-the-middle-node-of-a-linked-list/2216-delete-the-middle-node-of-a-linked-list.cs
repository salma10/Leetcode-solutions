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
    public ListNode DeleteMiddle(ListNode head) {
        if(head == null || head.next == null)
            return null;
        
        ListNode hare = head;
        ListNode tortoise = head;
        ListNode newMiddleNode = null;

        while(hare != null && hare.next != null)
        {
            newMiddleNode = tortoise;
            tortoise = tortoise.next;
            hare = hare.next == null ? null : hare.next.next;
        }
  
        newMiddleNode.next = tortoise.next;
        return head;
    }
}