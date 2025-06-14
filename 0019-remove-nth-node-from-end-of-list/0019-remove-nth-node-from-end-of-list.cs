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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode nTh = head, temp = head;
        
        while(temp != null)
        {
            if(n-- < 0) 
                nTh = nTh.next;
            temp = temp.next;
        }
        if(n == 0) 
            return nTh.next;
        
        nTh.next = nTh.next.next;
        
        return head;
    }
}