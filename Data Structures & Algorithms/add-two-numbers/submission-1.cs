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
        var head = new ListNode(0);
        var result = head;

        int carry = 0;
        while(l1 != null || l2 != null || carry != 0){
            
            int l1Val = (l1 != null) ? l1.val: 0;
            int l2Val = (l2 != null) ? l2.val: 0;

            int sum = l1Val + l2Val + carry;

            carry = sum / 10; //1
            int digit = sum % 10; //8

            result.next = new ListNode(digit);
            result = result.next;

            
            l1 = (l1 != null) ? l1.next: null;
            l2 = (l2 != null) ? l2.next : null;
        }

        return head.next;
    }
}
