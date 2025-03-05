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
    public int PairSum(ListNode head) {
        int totalNodes = 0;
        int maxSum = 0;

        ListNode current = head;

        while(current != null)
        {
            totalNodes++;
            current = current.next;
        }

        int noOfNodesToReverse = totalNodes / 2;
        current = head;

        while(noOfNodesToReverse > 0)
        {
            noOfNodesToReverse--;
            current = current.next;
        }
        current = ReverseList(current);
        
        while(current != null)
        {
            maxSum = Math.Max(maxSum, current.val + head.val);
            current = current.next;
            head = head.next;
        }

        return maxSum;
    }
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while (current != null)
        {
            next = current.next; 
            current.next = prev;  
            prev = current; 
            current = next;
        }

        return prev;
    }
}