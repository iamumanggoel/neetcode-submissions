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
    public void ReorderList(ListNode head) {
        if(head is null || head.next is null)
            return;

        //divide into two halves
        ListNode slow = head, fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        //reverse the 2nd half
        ListNode prev = null;
        ListNode curr = slow.next;
        slow.next = null;
        
        while(curr != null){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }


        //merge linked lists
        ListNode first = head, second = prev;

        while(second != null){
            var firstnext = first.next;
            var secondnext = second.next;

            first.next = second;
            second.next = firstnext;

            first = firstnext;
            second = secondnext;
        }
    }
}
