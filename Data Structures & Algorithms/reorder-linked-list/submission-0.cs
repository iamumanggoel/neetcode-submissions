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


// 0->1->2->3->4->5->6
// 1. Divide in two using fast & slow pointer
// part1: 0->1->2->3  
// part2: 4->5->6
// 2. Reverse the second half
// part1: 0->1->2->3
// part2: 6->5->4
// 3. Merge both
// 0->6->1->5->2->4->3

public class Solution {
    public void ReorderList(ListNode head) {

        if(head is null || head.next is null)
            return;


        ListNode fast = head, slow = head;

        //Find Middle part
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        //Reverse 2nd part
        ListNode curr = slow.next;
        slow.next = null;
        ListNode prev = null;
        while(curr != null){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        //1-2-3-4  5-6-7
        //merge both 
        ListNode first = head, second = prev;

        while(second != null){
            ListNode f1Next = first.next;
            ListNode s1Next = second.next;

            first.next = second;
            second.next = f1Next;

            first = f1Next;
            second = s1Next;
        }
        
    }
}
