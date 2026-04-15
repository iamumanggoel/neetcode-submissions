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
    public bool HasCycle(ListNode head) {
        var seen = new HashSet<ListNode>();

        while(head != null){

            if(!seen.Add(head))
                return true;

            head = head.next;
        }

        return false;
    }
}
