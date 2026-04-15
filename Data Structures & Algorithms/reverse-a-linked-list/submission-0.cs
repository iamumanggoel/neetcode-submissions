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
    public ListNode ReverseList(ListNode head) {
        ListNode headNodeToNew = head;
        ListNode MaintainNode = null;

        while(headNodeToNew != null){
            //iteration statements
            ListNode temp = headNodeToNew.next;

            //LOGIC
            headNodeToNew.next = MaintainNode;
            MaintainNode = headNodeToNew;

            //itenation statemnets
            headNodeToNew = temp;
        }
        return MaintainNode;
    }
}
