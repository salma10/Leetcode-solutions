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
        int maxSum = 0;

        ListNode reversedList = null;
        ListNode current = head;
        ListNode hare = head;

        while(hare != null)
        {
            hare = hare.next.next;
            ListNode next = current.next; 
            current.next = reversedList;  
            reversedList = current; 
            current = next;
        }

        while(current != null)
        {
            maxSum = Math.Max(maxSum, current.val + reversedList.val);
            current = current.next;
            reversedList = reversedList.next;
        }

        return maxSum;
    }
}