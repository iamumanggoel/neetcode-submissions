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
        int size = 0;

        ListNode tmp = head;

        while(tmp != null){
            tmp = tmp.next;
            size++;
        }

        if(size - n == 0)
            return head.next;


        int i = 0; 
        ListNode tmp2 = head;
        while(i != (size - n - 1)){
            i++;
            tmp2 = tmp2.next;
        }
        tmp2.next = tmp2.next.next;


        return head;
        
    }
}
