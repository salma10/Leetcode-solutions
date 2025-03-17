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
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null)
            return head;
        
        ListNode root = head;
        ListNode evenNode = head.next;
        ListNode evenHead = evenNode;
        ListNode current = evenNode.next;
        int oddEven = 1;
        
        while(current != null)
        {
            if(oddEven == 1)
            {
                root.next = current;
                root = root.next;
                oddEven = 2;
            }  
            else
            {
                evenNode.next = current;
                evenNode = evenNode.next;
                oddEven = 1;
            }
            current = current.next;
        }
        evenNode.next = null;
        root.next = evenHead;
        return head;
    }
}