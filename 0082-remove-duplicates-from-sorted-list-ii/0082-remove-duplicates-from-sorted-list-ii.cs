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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null)
            return head;
        ListNode prev = head;
        bool duplicateFound = false;

        while(head.next != null)
        {
            if(head.next != null && head.val == head.next.val)
            {
               head.next = head.next.next; 
               duplicateFound = true;
            } 
            else if(duplicateFound)
            {
                head = head.next;
                prev = head;
                duplicateFound = false;
            } 
            else
               break;
        }
        if(duplicateFound && head.next == null)
        {
           prev = null;
        }
        
        while(head.next != null)
        {
            if(head.next != null && head.next.next != null && head.next.val == head.next.next.val)
            {
               duplicateFound = true;
               head.next = head.next.next; 
            } 
            else if(duplicateFound)
            {
                duplicateFound = false;
                head.next = head.next.next; 
            } 
            else
            {
               duplicateFound = false;
               head = head.next; 
            }
                
        }
        return prev;
    }
}