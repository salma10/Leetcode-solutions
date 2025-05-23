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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;        
       
        return Sum(l1, l2, 0);       
    }
    
    private ListNode Sum(ListNode l1, ListNode l2, int remainder)
    {
        if(l1 == null && l2 == null)
        {
           return remainder == 0 ? null : new ListNode(remainder); 
        }
        
        if((l1 == null || l2 == null) && remainder == 0)
        {
            if(l1 == null)
                return l2;
            else
                return l1;
        }
        l1 = l1 == null ? new ListNode(0) : l1;
        l2 = l2 == null ? new ListNode(0) : l2;
        int nodeSum = l1.val + l2.val + remainder;

        ListNode currNode = new ListNode();
        currNode.val = nodeSum != 0 ? nodeSum % 10 : 0;
        remainder =  nodeSum != 0 ? nodeSum / 10 : 0;
        
        currNode.next = Sum(l1.next, l2.next, remainder);
        return currNode;
    }
}