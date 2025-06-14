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
    public ListNode RotateRight(ListNode head, int k) {
        
        if(k < 1 || head == null)
            return head;
        
        int len = 0;
        ListNode currentNode = head;
        while(currentNode != null)
        {
            len++;
            currentNode = currentNode.next;
        }
        k %= len;
        int nodesToMove = len - k;
        currentNode = head;
        ListNode currentHead = new ListNode();
        
        while(nodesToMove > 0)
        {
            nodesToMove--;
            if(nodesToMove == 0)
            {
                currentHead.next = currentNode.next;
                currentNode.next = null;
            }
            currentNode = currentNode.next;
        }
        currentNode = currentHead;
        while(currentHead.next != null)
        {
            currentHead = currentHead.next;
        }
        currentHead.next = head;
        return currentNode.next;
    }
}